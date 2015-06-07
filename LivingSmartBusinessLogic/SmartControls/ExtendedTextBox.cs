using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartControls
{
	/// <summary>
	/// Simple udvidelse af TextBox, der tilføjer mulighed for placeholder tekst
	/// </summary>
	/// <author>Mathias Petersen</author>
	internal partial class ExtendedTextBox : TextBox
	{
		/// <summary>
		/// Angiver en placeholder til tekstfeltet
		/// </summary>
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

		//Lytter på beskeder fra vinduet
		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);

			//Hvis beskeden har id'et 0x00f er det en paint event fra vinduet.
			//Efter kan vi tegne placeholderen over det den allerede har tegnet.
			if (m.Msg == 0x00f)
				DrawPlaceholder();
		}

		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);
			//Tvinger den til at tegne placeholderen når teksten ændres.
			DrawPlaceholder();
		}

		private void DrawPlaceholder()
		{
			//Hvis der står noget tekst i tekstfeltet skal der ikke vises en placeholder
			if (!string.IsNullOrEmpty(Text))
				return;

			Graphics g = CreateGraphics();
				TextRenderer.DrawText(g, Placeholder, Font,
					new Rectangle(-2, -1, ClientRectangle.Width, ClientRectangle.Height),
					SmartColor.DarkA75, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
			g.Dispose();
		}
	}
}
