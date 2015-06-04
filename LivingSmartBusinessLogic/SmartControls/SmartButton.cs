using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartControls
{
	public class SmartButton : Button
	{
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
		
		protected override Size DefaultSize { get { return new Size(75, 30);} }
		protected override Padding DefaultMargin { get { return Padding.Empty; } }
		protected override Padding DefaultPadding { get { return new Padding(15, 0, 15, 0); } }

		private Font _font = new Font(new FontFamily("Segoe UI"), 9.75f);
		public override Font Font
		{
			get { return _font; }
			set
			{
				_font = value;
				Invalidate();
			}
		}
		
		public SmartButton()
		{
			FlatStyle = FlatStyle.Flat;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;

			UpdateColor();
			FlatAppearance.BorderSize = 0;
			Cursor = Cursors.Hand;

			MouseEnter += OnMouseEnter;
			MouseLeave += OnMouseLeave;
		}

		public override Size GetPreferredSize(Size proposedSize)
		{
			var baseSize = base.GetPreferredSize(proposedSize);
			baseSize.Height = 30;
			return baseSize;
		}

		private void UpdateColor()
		{
			ForeColor = (Color == SmartColor.ColorStyle.Light) ? SmartColor.Dark : SmartColor.Light;
			BackColor = (Color == SmartColor.ColorStyle.Light) ? SmartColor.Light : SmartColor.Dark;
			FlatAppearance.MouseOverBackColor = FlatAppearance.MouseDownBackColor = (Color == SmartColor.ColorStyle.Light) ? SmartColor.Dark : SmartColor.Light;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			if (Enabled)
			{
				base.OnPaint(e);
			}
			else
			{
				e.Graphics.FillRectangle(new SolidBrush(BackColor), new Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height));
				TextRenderer.DrawText(e.Graphics, Text, Font, new Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height),
					SmartColor.DarkA75);// (Color == SmartColor.ColorStyle.Light) ? SmartColor.DarkA25 : SmartColor.LightA25);
			}
		}

		#region Event Handler Methods

		private void OnMouseEnter(object sender, EventArgs eventArgs)
		{
			ForeColor = (Color == SmartColor.ColorStyle.Light) ? SmartColor.Light : SmartColor.Dark;
			Invalidate();//Gør at knappen bliver tegnet på ny
		}
		private void OnMouseLeave(object sender, EventArgs eventArgs)
		{
			ForeColor = (Color == SmartColor.ColorStyle.Light) ? SmartColor.Dark : SmartColor.Light;
			Invalidate();//Gør at knappen bliver tegnet på ny
		}

		#endregion

	}
}
