using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SmartControls
{
	public partial class MenuButton : Button
	{
		#region Style

		/*private ColorStyle _color;
		public ColorStyle Color
		{
			get { return _color; }
			set { _color = value; Invalidate(); }
		}*/

		#endregion

		#region States

		private bool _hovering;
	
		#endregion

		#region Defaults
		
		protected override Padding DefaultMargin { get {return new Padding(0);} }

		protected override Size DefaultSize { get {return new Size(125, 30);} }

		protected override Padding DefaultPadding { get {return new Padding(15,0,15,0);} }
		
		#endregion

		#region Selected
		private bool _selected;
		[Browsable(true)]
		[Category("Appearance")]
		[Description("Indicates whether the button is selected")]
		[DisplayName("Selected")]
		public bool Selected
		{
			get { return _selected; }
			set { _selected = value; Invalidate(); }
		}
		#endregion

		#region Text
		//Keyword new gør at denne variabler overskrive en eksisterende variabel 
		//af samme navn fra Control klassen 
		public new String Text
		{
			get { return base.Text; }
			set
			{
				base.Text = value;
				Size = GetPreferredSize(new Size(0, 0));
				Invalidate();
			}
		}
		#endregion

		#region Padding
		//Keyword new g�r at denne variabler overskrive en eksiterende variabel 
		//af samme navn fra Control klassen 
		public new Padding Padding
		{
			get { return base.Padding; }
			set
			{
				base.Padding = value;
				base.Size = GetPreferredSize(new Size(0, 0));
				Invalidate();
			}
		}
		#endregion


		public enum ColorStyle
		{
			Light,
			Dark
		}

		public MenuButton()
		{
			InitializeComponent();

			MouseEnter += OnMouseEnter;
			MouseLeave += OnMouseLeave;
			
			Size = GetPreferredSize(new Size(0, 0));
		}

		public override Size GetPreferredSize(Size proposedSize)
		{
			//Beregner først tekstens størrelse, og retunere derefter den 
			//endelig størrelse på knappen
			Graphics g = CreateGraphics();
			Size preferredSize = g.MeasureString(Text, Font).ToSize();
			preferredSize.Height = 30;
			preferredSize.Width++;
			Size requiredSize = preferredSize + Padding.Size;
			return requiredSize;
		}


		#region Paint

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			StringFormat style = new StringFormat();
			style.Alignment = StringAlignment.Center;
			style.LineAlignment = StringAlignment.Center;



			//Draw background
			Color bgColor = (_hovering || Selected) ? SmartColor.Dark : SmartColor.Light;
			e.Graphics.FillRectangle(new SolidBrush(bgColor), new Rectangle(ClientRectangle.Left, ClientRectangle.Top, ClientRectangle.Width, ClientRectangle.Height));

			//Draw text
			Rectangle paddedRectangle = new Rectangle(Padding.Left, Padding.Top, ClientRectangle.Width - Padding.Size.Width, ClientRectangle.Height - Padding.Size.Height);

			Color textColor = (_hovering || Selected) ? SmartColor.Light : SmartColor.Dark;
			e.Graphics.DrawString(Text, Font, new SolidBrush(textColor), paddedRectangle, style);
		}

		#endregion

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
