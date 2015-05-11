using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartControls
{
	public partial class SmartLabel : Label
	{
		#region Title

		private string _title;
		[Category("Appearance")]
		public string Title
		{
			get { return _title; }
			set
			{
				_title = value;
				Size = GetPreferredSize(new Size(0, 0));
				Invalidate();
			}
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

		public SmartLabel()
		{
			InitializeComponent();

			Size = GetPreferredSize(new Size(0, 0));

			Invalidate();
		}

		public override Size GetPreferredSize(Size proposedSize)
		{
			//Beregner først tekstens størrelse, og retunere derefter den 
			//endelig størrelse på knappen

			var titleFont = new Font(Font, FontStyle.Bold);
			var textFont = Font;
			
			var titleSize = TextRenderer.MeasureText(Title, titleFont);
			var textSize = TextRenderer.MeasureText(Text, textFont);

			Size preferredSize = new Size(titleSize.Width + textSize.Width, titleSize.Height);

			preferredSize.Width += 2;

			Size requiredSize = preferredSize + Padding.Size;
			return requiredSize;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			//base.OnPaint(e);

			StringFormat style = new StringFormat();
			style.Alignment = StringAlignment.Near;
			style.LineAlignment = StringAlignment.Far;

			var titleFont = new Font(Font, FontStyle.Bold);
			var textFont = Font;

			var titleSize = TextRenderer.MeasureText(Title, titleFont);
			var textSize = TextRenderer.MeasureText(Text, textFont);

			Console.WriteLine(titleSize);
			Console.WriteLine(textSize);
			Console.WriteLine(ClientRectangle);


			e.Graphics.DrawString(Title, titleFont, new SolidBrush(ForeColor), new Rectangle(ClientRectangle.X, ClientRectangle.Y, titleSize.Width, titleSize.Height), style);

			e.Graphics.DrawString(Text, textFont, new SolidBrush(ForeColor), new Rectangle(ClientRectangle.X + titleSize.Width, ClientRectangle.Y, ClientRectangle.Width-titleSize.Width, titleSize.Height), style);
		}
	}
}
