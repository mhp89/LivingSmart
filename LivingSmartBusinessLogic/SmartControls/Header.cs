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
	public class Header : Control
	{
		[Category("Appearance")]
		public SmartColor.ColorStyle Color
		{
			get { return _color; }
			set { _color = value; UpdateColor(); }
		}
		private SmartColor.ColorStyle _color;

		private Font _font = new Font(new FontFamily("Segoe UI"), 11.25f, FontStyle.Bold);
		public override Font Font
		{
			get { return _font; }
			set { _font = value; Invalidate(); }
		}

		protected override Padding DefaultMargin { get { return new Padding(10,0,10,0);} }
		protected override Size DefaultSize { get { return new Size(150, 25); } }
		protected override Padding DefaultPadding { get { return new Padding(5,0,0,0); } }

		protected override void OnPaddingChanged(EventArgs e)
		{
			base.OnPaddingChanged(e);
			Invalidate();
		}

		public override string Text { get { return base.Text; } set { base.Text = value; Invalidate(); } }
		
		private Color BorderColor;

		public Header()
		{
			UpdateColor();
		}

		private void UpdateColor()
		{
			ForeColor = BorderColor  = (Color == SmartColor.ColorStyle.Light) ? SmartColor.Light : SmartColor.Dark;
			Invalidate();
		}


		protected override void OnPaint(PaintEventArgs e)
		{
			//Beregner størrelsen til teksterne, udfra tekst, font.
			var textSize = TextRenderer.MeasureText(e.Graphics, Text, Font,
				Size.Empty, TextFormatFlags.Left);

			//Beregner firkanten teksterne skal tegnes i
			Rectangle textRectangle = AdjustedRect(
				new Rectangle(e.ClipRectangle.X, e.ClipRectangle.Y,
					textSize.Width, e.ClipRectangle.Height),
				Padding
			);

			//Tegner teksterne
			TextRenderer.DrawText(e.Graphics, Text, Font, textRectangle, ForeColor, TextFormatFlags.Left);
			e.Graphics.FillRectangle(new SolidBrush(BorderColor), new Rectangle(0, Height-2, Width, 2));
		}

		/// <summary>
		/// Justere rectangle i forhold til padding
		/// </summary>
		/// <param name="rect">Oprindelig rectangle</param>
		/// <param name="padding">Padding for hele SmartLabel'en</param>
		/// <returns>Justeret rectangle</returns>
		private static Rectangle AdjustedRect(Rectangle rect, Padding padding)
		{
			rect.X += padding.Left;
			rect.Y += padding.Top;
			rect.Width -= padding.Horizontal;
			rect.Height -= padding.Vertical;
			return rect;
		}
	}
}
