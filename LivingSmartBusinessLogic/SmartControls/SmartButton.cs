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
		private MenuButton.ColorStyle _color;
		[Category("Appearance")]
		public MenuButton.ColorStyle Color
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
			}
		}

		public SmartButton()
		{
			FlatStyle = FlatStyle.Flat;

			UpdateColor();
			FlatAppearance.BorderSize = 0;
			Cursor = Cursors.Hand;

			MouseEnter += OnMouseEnter;
			MouseLeave += OnMouseLeave;
		}

		private void UpdateColor()
		{
			ForeColor = (Color == MenuButton.ColorStyle.Light) ? SmartColor.Dark : SmartColor.Light;
			BackColor = (Color == MenuButton.ColorStyle.Light) ? SmartColor.Light : SmartColor.Dark;
			FlatAppearance.MouseOverBackColor = FlatAppearance.MouseDownBackColor = (Color == MenuButton.ColorStyle.Light) ? SmartColor.Dark : SmartColor.Light;
		}

		#region Event Handler Methods

		private void OnMouseEnter(object sender, EventArgs eventArgs)
		{
			ForeColor = (Color == MenuButton.ColorStyle.Light) ? SmartColor.Light : SmartColor.Dark;
			Invalidate();//Gør at knappen bliver tegnet på ny
		}
		private void OnMouseLeave(object sender, EventArgs eventArgs)
		{
			ForeColor = (Color == MenuButton.ColorStyle.Light) ? SmartColor.Dark : SmartColor.Light;
			Invalidate();//Gør at knappen bliver tegnet på ny
		}

		#endregion

	}
}
