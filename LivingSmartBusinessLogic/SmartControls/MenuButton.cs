using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SmartControls
{
	/// <summary>
	/// Knap til topmenuen
	/// </summary>
	/// <author>Mathias Petersen</author>
	public partial class MenuButton : Button
	{
		#region States

		private bool _hovering;
	
		#endregion

		#region Defaults
		
		protected override Padding DefaultMargin { get {return Padding.Empty;} }

		protected override Size DefaultSize { get {return new Size(125, 30);} }

		protected override Padding DefaultPadding { get {return new Padding(15,0,15,0);} }
		
		#endregion

		#region Selected

		/// <summary>
		/// Indicates if the button is selected
		/// </summary>
		[Browsable(true)]
		[Category("Appearance")]
		[Description("Indicates whether the button is selected")]
		[DisplayName("Selected")]
		public bool Selected
		{
			get { return _selected; }
			set { _selected = value; Invalidate(); }
		}
		private bool _selected;

		#endregion

		#region Text

		public override String Text
		{
			get { return base.Text; }
			set
			{
				base.Text = value;
				UpdateAutosize();
			}
		}
		#endregion

		#region Padding
		//Keyword new gør at denne variabel overskrive en eksisterende
		//variabel af samme navn fra Control klassen
		public new Padding Padding
		{
			get { return base.Padding; }
			set
			{
				base.Padding = value;
				UpdateAutosize();
			}
		}
		#endregion

		
		public MenuButton()
		{
			InitializeComponent();

			Cursor = Cursors.Hand;

			MouseEnter += OnMouseEnter;
			MouseLeave += OnMouseLeave;

			UpdateAutosize();
		}

		/// <summary>
		/// Retter størrelsen i forhold til teksten, hvis AutoSize er slået til
		/// </summary>
		private void UpdateAutosize()
		{
			if (AutoSize)
			{
				Size = GetPreferredSize(Size.Empty);
				Invalidate();
			}
		}

		public override Size GetPreferredSize(Size proposedSize)
		{
			Graphics gr = CreateGraphics();

			//Finder relevante flag
			TextFormatFlags flags = CreateTextFormatFlags();

			//Beregner størrelsen til teksten
			var textMeasured = TextRenderer.MeasureText(gr, Text, Font, Size.Empty, flags);

			//Beregner den ønskede størrelsen til hele knappen
			Size preferredSize = new Size(textMeasured.Width, 30);

			//Justere størrelsen i forhold til padding
			Size requiredSize = preferredSize + Padding.Size;

			return requiredSize;
		}


		#region Paint

		protected override void OnPaint(PaintEventArgs e)
		{
			//Tegner baggrunden
			Color bgColor = (_hovering || Selected) ? SmartColor.Dark : SmartColor.Light;
			e.Graphics.FillRectangle(new SolidBrush(bgColor), new Rectangle(ClientRectangle.Left, ClientRectangle.Top, ClientRectangle.Width, ClientRectangle.Height));


			//Finder relevante flag for teksten
			TextFormatFlags flags = CreateTextFormatFlags();
			Color textColor = (_hovering || Selected) ? SmartColor.Light : SmartColor.Dark;
			
			//Berenger firkanten teksten skal tegnes i
			Rectangle textRectangle = AdjustedRect(new Rectangle(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height), Padding);
			
			//Tegner teksten
			TextRenderer.DrawText(e.Graphics, Text, Font, textRectangle, textColor, flags);
		}

		#endregion


		/// <summary>
		/// Justere rectangle i forhold til padding
		/// </summary>
		/// <param name="rect">Oprindelig rectangle</param>
		/// <param name="padding">Padding for teksten</param>
		/// <returns>Justeret rectangle</returns>
		private static Rectangle AdjustedRect(Rectangle rect, Padding padding)
		{
			rect.X += padding.Left;
			rect.Y += padding.Top;
			rect.Width -= padding.Horizontal;
			rect.Height -= padding.Vertical;
			return rect;
		}

		/// <summary>
		/// Finder de rigtige flags ud fra parameterne
		/// </summary>
		/// <returns>Relevante flags</returns>
		private static TextFormatFlags CreateTextFormatFlags()
		{
			TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;


			return flags;
		}

		#region Event Handler Methods
	
		private void OnMouseEnter(object sender, EventArgs eventArgs)
		{
			_hovering = true;
			Invalidate();//Gør at knappen bliver tegnet på ny
		}
		private void OnMouseLeave(object sender, EventArgs eventArgs)
		{
			_hovering = false;
			Invalidate();//Gør at knappen bliver tegnet på ny
		}
	
		#endregion
	}
}
