using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartControls
{
	public class SmartTextBox : Control
	{
		private bool firstDraw = true;

		private ExtendedTextBox textBox;
		private ToolTip toolTip;

		private Color BorderColor;


		#region Appearance

		[Category("Appearance")]
		public SmartColor.ColorStyle Color
		{
			get { return _color; }
			set
			{
				_color = value;
				UpdateColor();
			}
		}
		private SmartColor.ColorStyle _color;

		public override string Text
		{
			get { return _text??String.Empty; }
			set
			{
				if (value != Text)
					_text = textBox.Text = value;
			}
		}
		private string _text;

		[Category("Appearance")]
		public string Suffix
		{
			get { return _suffix; }
			set { _suffix = value; UpdateSize(); Invalidate(); }
		}
		private string _suffix;

		[Category("Appearance")]
		public string Placeholder
		{
			get { return _placeholder; }
			set { _placeholder = textBox.Placeholder = value; }
		}
		private string _placeholder;

		#endregion


		#region Behavior

		[Category("Behavior")]
		public int MaxLength
		{
			get { return textBox.MaxLength; }
			set { textBox.MaxLength = value; }
		}

		[Category("Behavior")]
		public bool UseSystemPasswordChar
		{
			get { return _useSystemPasswordChar; }
			set { _useSystemPasswordChar = textBox.UseSystemPasswordChar = value; }
		}
		private bool _useSystemPasswordChar;

		private AutoCompleteMode _autoCompleteMode;
		public AutoCompleteMode AutoCompleteMode
		{
			get { return textBox.AutoCompleteMode; }
			set { _autoCompleteMode = textBox.AutoCompleteMode = value; }
		}

		private AutoCompleteSource _autoCompleteSource;
		public AutoCompleteSource AutoCompleteSource
		{
			get { return textBox.AutoCompleteSource; }
			set { _autoCompleteSource = textBox.AutoCompleteSource = value; }
		}

		private AutoCompleteStringCollection _autoCompleteCustomSource;
		public AutoCompleteStringCollection AutoCompleteCustomSource
		{
			get { return textBox.AutoCompleteCustomSource; }
			set { _autoCompleteCustomSource = textBox.AutoCompleteCustomSource = value; }
		}

		#endregion


		#region Defaults
		
		protected override Padding DefaultMargin { get{return new Padding(10);} }

		protected override Size DefaultSize { get{return new Size(150,30);} }

		#endregion


		#region Validation

		private int errorIconSize = 10;

		[Category("Validation")]
		public bool NumericOnly { get; set; }

		[Category("Validation")]
		public bool AllowComma { get; set; }

		[Category("Validation")]
		public bool AutomaticValidation { get; set; }

		[Category("Validation"), ReadOnly(true)]
		public bool HasError
		{
			get { return CurrentErrorType != ErrorType.None; }
		}

		[Category("Validation"), ReadOnly(true)]
		public ErrorType CurrentErrorType { get; set; }

		[Category("Validation"), ReadOnly(true)]
		public string CustomErrorMessage { get; set; }

		[Category("Validation")]
		public string RegularExpression { get; set; }

		[Category("Validation")]
		public int MinLength
		{
			get { return _minLength; }
			set { _minLength = value; }
		}
		private int _minLength = -1;

		[Category("Validation")]
		public bool Required { get; set; }

		public enum ErrorType
		{
			None,
			ToShort,
			InvalidInput,
			Required,
			NumericOnly,
			Custom
		}
		
		#endregion
		
		public SmartTextBox()
		{
			Required = false;
			UpdateColor();
			Cursor = Cursors.IBeam;
			_text = String.Empty;
			TabStop = false;

			Controls.Add(textBox = new ExtendedTextBox());
			
			textBox.BorderStyle = BorderStyle.None;
			textBox.BackColor = BackColor;
			textBox.BorderStyle = BorderStyle.None;
			textBox.ForeColor = ForeColor;
			
			Click += OnClick;
			SizeChanged += SmartTextBox_SizeChanged;
			textBox.TextChanged += textBox_TextChanged;
			textBox.KeyPress += textBox_KeyPress;
			textBox.KeyDown += textBox_KeyDown;

			toolTip = new ToolTip();
			toolTip.InitialDelay = 500;
			toolTip.ReshowDelay = 350;

			UpdateSize();
		}

		void textBox_KeyDown(object sender, KeyEventArgs e)
		{
			//Når TextBox'en får en KeyDown event, videresendes den til SmartTextBox
			OnKeyDown(e);
		}

		void textBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			//Hvis feltet kun må indholde tal
			if (NumericOnly)
			{
				bool error = false;

				//Hvis tasten ikke er et tal, komma eller en kontrol key, er det en fejl
				if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ','))
					error = true;
				else if (e.KeyChar == ',' && (!AllowComma || textBox.Text.IndexOf(',') > -1))
					error = true;
				
				//Annullere key eventen hvis error er true
				e.Handled = error;
			}
		}

		void textBox_TextChanged(object sender, EventArgs e)
		{
			Text = textBox.Text;

			if (AutomaticValidation)
				Validate();

			//Efter egenvalidering sendes eventen videre til andre evt. lyttere
			OnTextChanged(e);
		}

		void SmartTextBox_SizeChanged(object sender, EventArgs e)
		{
			UpdateSize();
		}

		/// <summary>
		/// Flytter fokus til tekstfeltet
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="eventArgs"></param>
		private void OnClick(object sender, EventArgs eventArgs)
		{
			textBox.Focus();
		}

		protected override void OnPaintBackground(PaintEventArgs e)
		{
			base.OnPaintBackground(e);

			e.Graphics.FillRectangle(new SolidBrush(BackColor), new Rectangle(1, 1, ClientRectangle.Width-2, ClientRectangle.Height-2));
			e.Graphics.DrawRectangle(new Pen(BorderColor), new Rectangle(0, 0, Width-1, Height-1));
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			//FIX: Sikrer korrekt størrelse 
			if (firstDraw)
			{
				UpdateSize();
				firstDraw = false;
			}

			base.OnPaint(e);

			var suffixSizeBuffer = Size.Empty;

			if (!string.IsNullOrEmpty(Suffix))
			{
				var suffixSize = TextRenderer.MeasureText(CreateGraphics(), Suffix, Font, Size.Empty);
				suffixSizeBuffer = suffixSize;
				suffixSizeBuffer.Width += 10;

				e.Graphics.FillRectangle(new SolidBrush(SmartColor.DarkA75), new Rectangle(Width - suffixSizeBuffer.Width, 0, suffixSizeBuffer.Width, Height));
				TextRenderer.DrawText(e.Graphics, Suffix, Font, new Rectangle(Width - suffixSize.Width - 5, 0, suffixSize.Width, Height), SmartColor.Light);
			}

			if (HasError)
			{
				var pen = new Pen(ForeColor, 2);
				var offset = new Point(Width - errorIconSize - 10 - suffixSizeBuffer.Width, (Height - errorIconSize) / 2);
				e.Graphics.DrawLine(pen, AddPoints(new Point(0, 0), offset), AddPoints(new Point(errorIconSize - 1, errorIconSize - 1), offset));
				e.Graphics.DrawLine(pen, AddPoints(new Point(0, errorIconSize - 1), offset), AddPoints(new Point(errorIconSize - 1, 0), offset));
			}
		}

		/// <summary>
		/// Addere to Points
		/// </summary>
		/// <param name="point1"></param>
		/// <param name="point2"></param>
		/// <returns></returns>
		private Point AddPoints(Point point1, Point point2)
		{
			return new Point(point1.X + point2.X, point1.Y + point2.Y);
		}

		/// <summary>
		/// Beregner en ny størrelse til tekstfeltet og justere placeringen
		/// </summary>
		private void UpdateSize()
		{
			if(textBox == null)
				return;

			textBox.Width = Width - 10;
			if (HasError)
				textBox.Width -= (errorIconSize + 10);

			if (!string.IsNullOrEmpty(Suffix))
			{
				var suffixSize = TextRenderer.MeasureText(CreateGraphics(), Suffix, Font, Size.Empty);
				textBox.Width -= (suffixSize.Width+10);
			}
			textBox.Location = new Point(5, (Height - textBox.Height) / 2);
		}

		/// <summary>
		/// Opdatere farverne ud fra valgt ColorStyle
		/// </summary>
		private void UpdateColor()
		{
			ForeColor = BorderColor = (Color == SmartColor.ColorStyle.Light) ? SmartColor.Dark : SmartColor.Light;
			BackColor = (Color == SmartColor.ColorStyle.Light) ? SmartColor.Light : SmartColor.Dark;
		}

		/// <summary>
		/// Validere det indtastet i tekstfeltet, og sætter en evt. fejl
		/// </summary>
		/// <returns></returns>
		public bool Validate()
		{
			ClearError();
			
			if (DesignMode)
				return false;

			if (Required && string.IsNullOrEmpty(Text))
			{
				SetError(ErrorType.Required);
			}
			if (MinLength > 0 && Text.Length < MinLength)
			{
				SetError(ErrorType.ToShort);
			}
			else if (!string.IsNullOrEmpty(RegularExpression) && !Regex.IsMatch(Text, RegularExpression))
			{
				SetError(ErrorType.InvalidInput);
			}
			else if (NumericOnly && Regex.IsMatch(Text, "[^0-9]"))
			{
				SetError(ErrorType.NumericOnly);
			}

			return !HasError;
		}

		/// <summary>
		/// Fjerner fejlen på tekstefeltet.
		/// </summary>
		public void ClearError()
		{
			CurrentErrorType = ErrorType.None;
			UpdateSize();

			toolTip.RemoveAll();
		}
	
		/// <summary>
		/// Sætter fejlen på tekstfeltet.
		/// </summary>
		/// <param name="errorType">Fejltypen</param>
		public void SetError(ErrorType errorType)
		{
			CurrentErrorType = errorType;
			UpdateSize();

			toolTip.SetToolTip(this, GetErrorMsgText());
			toolTip.SetToolTip(textBox, GetErrorMsgText());
		}

		/// <summary>
		/// Sætter fejlen til en brugerdefineret tekst
		/// </summary>
		/// <param name="customErrorMessage"></param>
		public void SetError(string customErrorMessage)
		{
			CustomErrorMessage = customErrorMessage;
			CurrentErrorType = ErrorType.Custom;
			UpdateSize();

			toolTip.SetToolTip(this, GetErrorMsgText());
			toolTip.SetToolTip(textBox, GetErrorMsgText());
		}

		/// <summary>
		/// Retunere fejlteksten svarende til fejltypen
		/// </summary>
		/// <returns></returns>
		private string GetErrorMsgText()
		{
			string text = "";

			if (CurrentErrorType == ErrorType.Required)
				text = "Feltet skal være udfyldt";
			else if (CurrentErrorType == ErrorType.ToShort)
				text = "Feltet skal mindst være " + MinLength + " lang";
			else if (CurrentErrorType == ErrorType.InvalidInput)
				text = "Ugyldigt input";
			else if (CurrentErrorType == ErrorType.NumericOnly)
				text = "Kun tal er tilladt";
			else if (CurrentErrorType == ErrorType.Custom)
				text = CustomErrorMessage;

			return text;
		}
	}
}
