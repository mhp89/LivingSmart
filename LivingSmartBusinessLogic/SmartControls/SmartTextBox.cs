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
		private TextBox textBox;
		private ToolTip toolTip;

		private SmartColor.ColorStyle _color;
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

		private Color BorderColor;

		private string _text;
		public override string Text
		{
			get { return _text; }
			set { _text = textBox.Text = value; }
		}

		#region Defaults
		
		protected override Padding DefaultMargin { get{return new Padding(10);} }

		protected override Size DefaultSize { get{return new Size(150,30);} }

		#endregion


		#region Validation

		private int errorIconSize = 10;

		[Category("Validation")]
		public bool AutomaticValidation
		{
			get { return _automaticValidation; }
			set { _automaticValidation = value; }
		}
		private bool _automaticValidation;

		public bool HasError
		{
			get { return ErrorMsg != ErrorType.None; }
		}

		[Category("Validation")]
		public ErrorType ErrorMsg
		{
			get { return _errorMsg; }
			set { _errorMsg = value; }
		}
		private ErrorType _errorMsg;

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
			InvalidInput
		}
		
		#endregion


		public SmartTextBox()
		{
			UpdateColor();
			Cursor = Cursors.IBeam;

			Console.WriteLine(Controls.Count);
			Controls.Add(textBox = new TextBox());

			UpdateSize();

			textBox.BorderStyle = BorderStyle.None;
			textBox.BackColor = BackColor;
			textBox.BorderStyle = BorderStyle.None;
			textBox.ForeColor = ForeColor;

			textBox.Text = Text;
			
			Click += OnClick;
			SizeChanged += SmartTextBox_SizeChanged;
			//textBox.SizeChanged += SmartTextBox_SizeChanged;
			textBox.TextChanged += textBox_TextChanged;

			toolTip = new ToolTip();
			toolTip.InitialDelay = 1000;
			toolTip.ReshowDelay = 500;
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
			base.OnPaint(e);

			if (HasError)
			{
				var pen = new Pen(ForeColor, 2);
				var offset = new Point(Width - errorIconSize - 10, (Height - errorIconSize)/2);
				e.Graphics.DrawLine(pen, AddPoints(new Point(0, 0), offset), AddPoints(new Point(errorIconSize - 1, errorIconSize - 1), offset));
				e.Graphics.DrawLine(pen, AddPoints(new Point(0, errorIconSize - 1), offset), AddPoints(new Point(errorIconSize - 1, 0), offset));
			}
		}

		private Point AddPoints(Point point1, Point point2)
		{
			return new Point(point1.X + point2.X, point1.Y + point2.Y);
		}


		private void UpdateSize()
		{
			if(textBox == null)
				return;

			textBox.Width = Width - 10;
			if (HasError)
				textBox.Width -= (errorIconSize + 10);
			textBox.Location = new Point(5, (Height - textBox.Height) / 2);
		}
		private void UpdateColor()
		{
			ForeColor = BorderColor = (Color == SmartColor.ColorStyle.Light) ? SmartColor.Dark : SmartColor.Light;
			BackColor = (Color == SmartColor.ColorStyle.Light) ? SmartColor.Light : SmartColor.Dark;
		}


		public bool Validate()
		{
			ClearError();

			if (MinLength != -1 && Text.Length < MinLength)
			{
				SetError(ErrorType.ToShort);
			}
			else if (!string.IsNullOrEmpty(RegularExpression) && !new Regex(RegularExpression).IsMatch(Text))
			{
				SetError(ErrorType.InvalidInput);
			}

			return HasError;
		}

		public void ClearError()
		{
			ErrorMsg = ErrorType.None;
			UpdateSize();

			toolTip.RemoveAll();
		}
		public void SetError(ErrorType errorType)
		{
			ErrorMsg = errorType;
			UpdateSize();

			toolTip.SetToolTip(this, GetErrorMsgText(ErrorMsg));
			toolTip.SetToolTip(textBox, GetErrorMsgText(ErrorMsg));
		}

		private string GetErrorMsgText(ErrorType errorMsg)
		{
			string text = "";

			if (errorMsg == ErrorType.ToShort)
				text = "Feltet skal mindst være "+MinLength+" langt";
			else if (errorMsg == ErrorType.InvalidInput)
				text = "Ugyldigt input";

			return text;
		}
	}
}
