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

		private TextBox textBox;
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
			get { return _text; }
			set { _text = textBox.Text = value; }
		}
		private string _text;

		[Category("Appearance")]
		public string Suffix
		{
			get { return _suffix; }
			set { _suffix = value; UpdateSize(); Invalidate(); }
		}
		private string _suffix;

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

		#endregion


		#region Defaults
		
		protected override Padding DefaultMargin { get{return new Padding(10);} }

		protected override Size DefaultSize { get{return new Size(150,30);} }

		#endregion


		#region Validation

		private int errorIconSize = 10;

		[Category("Validation")]
		public bool NumericOnly
		{
			get { return _numericOnly; }
			set { _numericOnly = value; }
		}
		private bool _numericOnly;

		[Category("Validation")]
		public bool AllowComma
		{
			get { return _allowComma; }
			set { _allowComma = value; }
		}
		private bool _allowComma;

		[Category("Validation")]
		public bool AutomaticValidation
		{
			get { return _automaticValidation; }
			set { _automaticValidation = value; }
		}
		private bool _automaticValidation;

		[Category("Validation"), ReadOnly(true)]
		public bool HasError
		{
			get { return CurrentErrorType != ErrorType.None; }
		}

		[Category("Validation"), ReadOnly(true)]
		public ErrorType CurrentErrorType
		{
			get { return _currentErrorType; }
			set { _currentErrorType = value; }
		}
		private ErrorType _currentErrorType;

		[Category("Validation"), ReadOnly(true)]
		public string CustomErrorMessage
		{
			get { return _customErrorMessage; }
			set { _customErrorMessage = value; }
		}
		private string _customErrorMessage;

		[Category("Validation")]
		public string RegularExpression
		{
			get { return _regularExpression; }
			set { _regularExpression = value; }
		}
		private string _regularExpression;

		[Category("Validation")]
		public int MinLength
		{
			get { return _minLength; }
			set { _minLength = value; }
		}
		private int _minLength = -1;

		public enum ErrorType
		{
			None,
			ToShort,
			InvalidInput,
			NumericOnly,
			Custom
		}
		
		#endregion


		public SmartTextBox()
		{
			UpdateColor();
			Cursor = Cursors.IBeam;
		    _text = String.Empty;

		    Controls.Add(textBox = new TextBox());
			
			textBox.BorderStyle = BorderStyle.None;
			textBox.BackColor = BackColor;
			textBox.BorderStyle = BorderStyle.None;
			textBox.ForeColor = ForeColor;

			textBox.Text = Text;
			
			Click += OnClick;
			SizeChanged += SmartTextBox_SizeChanged;
			textBox.TextChanged += textBox_TextChanged;
			textBox.KeyPress += textBox_KeyPress;


			toolTip = new ToolTip();
			toolTip.InitialDelay = 1000;
			toolTip.ReshowDelay = 500;

			UpdateSize();
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

			e.Graphics.FillRectangle(new SolidBrush(BackColor), new Rectangle(1, 1, e.ClipRectangle.Width-2, e.ClipRectangle.Height-2));
			e.Graphics.DrawRectangle(new Pen(BorderColor), new Rectangle(0, 0, Width-1, Height-1));
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			//FIX: Sikre korrekt størrelse 
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

				e.Graphics.FillRectangle(new SolidBrush(SmartColor.DarkA25), new Rectangle(Width - suffixSizeBuffer.Width, 0, suffixSizeBuffer.Width, Height));
				TextRenderer.DrawText(e.Graphics, Suffix, Font, new Rectangle(Width - suffixSize.Width - 5, 0, suffixSize.Width, Height), ForeColor);
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

			if (MinLength != -1 && Text.Length < MinLength)
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

			if (CurrentErrorType == ErrorType.ToShort)
				text = "Feltet skal mindst være "+MinLength+" langt";
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
