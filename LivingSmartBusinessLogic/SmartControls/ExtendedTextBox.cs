using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartControls
{
	public partial class ExtendedTextBox : TextBox
	{
		public string Placeholder
		{
			get { return _placeholder; }
			set { _placeholder = value; Invalidate(); }
		}
		private string _placeholder;

		public ExtendedTextBox()
		{
			InitializeComponent();
		}

		//Lytter p� beskeder fra vinduet
		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);

			//Hvis beskeden har id'et 0x00f er det �n paint event fra vinduet.
			//Efter kan vi tegne placeholderen over det den allerede har tegnet.
			if (m.Msg == 0x00f)
				DrawPlaceholder();
		}

		protected override void OnTextChanged(EventArgs e)
		{
			//Tvinger den til at tegne placeholderen n�r teksten �ndres.
			base.OnTextChanged(e);
			DrawPlaceholder();
		}

		private void DrawPlaceholder()
		{
			Graphics g = CreateGraphics();
			if (string.IsNullOrEmpty(Text))
				TextRenderer.DrawText(g, Placeholder, Font, new Rectangle(-2, -1, ClientRectangle.Width, ClientRectangle.Height),
					SmartColor.DarkA75, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
			g.Dispose();
		}
	}
}
