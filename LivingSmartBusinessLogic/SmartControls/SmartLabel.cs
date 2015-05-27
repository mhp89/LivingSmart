using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SmartControls
{
	/// <summary>
	/// En udvidet version af Label, der også indeholder en titel
	/// </summary>
	/// <author>Mathias Petersen</author>
	public partial class SmartLabel : Label
	{
		#region Title

		private string _title = "Title";
		/// <summary>
		/// Titlen for SmartLabel
		/// </summary>
		[Category("Appearance")]
		public string Title
		{
			get { return _title; }
			set
			{
				_title = value;
				InvalidateTextSizeCache();
				UpdateAutosize();
			}
		}

		private Font _titleFont = new Font(new FontFamily("Segoe UI"), 9.75f, FontStyle.Bold);
		/// <summary>
		/// Font'en der bruges til titlen
		/// </summary>
		[Category("Appearance")]
		public Font TitleFont
		{
			get { return _titleFont; }
			set
			{
				_titleFont = value;
				InvalidateTextSizeCache();
				UpdateAutosize();
			}
		}

		#endregion

		#region Text
		/// <summary>
		/// Teksten for SmartLabel
		/// </summary>
		public new String Text
		{
			get { return base.Text; }
			set
			{
				base.Text = value;
				InvalidateTextSizeCache();
				UpdateAutosize();
			}
		}

		private Font _font = new Font(new FontFamily("Segoe UI"), 9.75f);
		public override Font Font
		{
			get { return _font; }
			set
			{
				_font = value;
				InvalidateTextSizeCache();
				UpdateAutosize();
			}
		}

		#endregion

		#region Defaults
		
		/// <summary>
		/// Den default margin for SmartLabel
		/// </summary>
		protected override Padding DefaultMargin { get { return Padding.Empty; } }

		#endregion

		private Size titleSizeCache = Size.Empty;
		private Size textSizeCache = Size.Empty;

		public SmartLabel()
		{
			InitializeComponent();
			
			UpdateAutosize();
		}

		private void UpdateAutosize()
		{
			//Tilpasser automatisk SmartLabel'ens størrelse efter hvor meget teksterne fylder
			if (AutoSize)
			{
				Size = GetPreferredSize(Size.Empty);
				Invalidate();
			}
			else
			{
				Invalidate();
			}
		}


		public override Size GetPreferredSize(Size proposedSize)
		{
			SetTextSizes();

			var height = textSizeCache.Height > titleSizeCache.Height ? textSizeCache.Height : titleSizeCache.Height;

			//Beregner den ønskede størrelsen til hele SmartLabel'en
			Size preferredSize = new Size(titleSizeCache.Width + textSizeCache.Width, height);
			
			//Justere størrelsen i forhold til padding
			Size requiredSize = preferredSize + Padding.Size;
			
			return requiredSize;
		}

		private void SetTextSizes()
		{
			if (titleSizeCache == Size.Empty || textSizeCache == Size.Empty)
			{
				//Finder relevante flag
				TextFormatFlags flags = CreateTextFormatFlags(TextAlign);

				//Beregner størrelsen til teksterne
				if (titleSizeCache == Size.Empty)
					titleSizeCache = TextRenderer.MeasureText(Title, TitleFont, Size.Empty, flags);

				if (textSizeCache == Size.Empty)
					textSizeCache = TextRenderer.MeasureText(Title, TitleFont, Size.Empty, flags);
			}
		}

		private void InvalidateTextSizeCache()
		{
			titleSizeCache = Size.Empty;
			textSizeCache = Size.Empty;
		}

		/// <summary>
		/// Tegner SmartLabel'en
		/// </summary>
		/// <param name="e"></param>
		protected override void OnPaint(PaintEventArgs e)
		{
			SetTextSizes();

			//Finder relevante flag
			TextFormatFlags flags = CreateTextFormatFlags(TextAlign);

			//Beregner firkanten teksterne skal tegnes i
			Rectangle titleRectangle = AdjustedRect(
				new Rectangle(ClientRectangle.X, ClientRectangle.Y, titleSizeCache.Width,
					ClientRectangle.Height),
				Padding
			);
			Rectangle textRectangle = AdjustedRect(
				new Rectangle(ClientRectangle.X + titleSizeCache.Width, ClientRectangle.Y,
					textSizeCache.Width, ClientRectangle.Height),
				Padding
			);
			
			//Tegner teksterne
			TextRenderer.DrawText(e.Graphics, Title, TitleFont, titleRectangle, ForeColor, flags);
			TextRenderer.DrawText(e.Graphics, Text, Font, textRectangle, ForeColor, flags);
		}

		private void DrawDebug(Rectangle titleRectangle, Rectangle textRectangle, PaintEventArgs e)
		{
			e.Graphics.FillRectangles(Brushes.DeepPink, new[]
			{
				new Rectangle(titleRectangle.X, titleRectangle.Y, 3, 3),
				new Rectangle(titleRectangle.X+titleRectangle.Width-3, titleRectangle.Y, 3, 3),
				new Rectangle(titleRectangle.X, titleRectangle.Y+titleRectangle.Height-3, 3, 3),
				new Rectangle(titleRectangle.X+titleRectangle.Width-3, titleRectangle.Y+titleRectangle.Height-3, 3, 3)
			});

			e.Graphics.FillRectangles(Brushes.DeepSkyBlue, new[]
			{
				new Rectangle(textRectangle.X, textRectangle.Y, 3, 3),
				new Rectangle(textRectangle.X+textRectangle.Width-3, textRectangle.Y, 3, 3),
				new Rectangle(textRectangle.X, textRectangle.Y+textRectangle.Height-3, 3, 3),
				new Rectangle(textRectangle.X+textRectangle.Width-3, textRectangle.Y+textRectangle.Height-3, 3, 3)
			});
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
			rect.Width += padding.Horizontal;
			rect.Height += padding.Vertical;
			return rect;
		}

		/// <summary>
		/// Finder de rigtige flags ud fra parameterne
		/// </summary>
		/// <param name="textAlign">Tekstens placering i SmartLabel'en</param>
		/// <returns>Relevante flags</returns>
		private static TextFormatFlags CreateTextFormatFlags(ContentAlignment textAlign)
		{
			TextFormatFlags flags = TextFormatFlags.Left;// | TextFormatFlags.NoPadding;

			if (textAlign == ContentAlignment.TopLeft ||
				textAlign == ContentAlignment.TopCenter ||
				textAlign == ContentAlignment.TopRight)
				flags = flags | TextFormatFlags.Top;
			else if (textAlign == ContentAlignment.MiddleLeft ||
				textAlign == ContentAlignment.MiddleCenter ||
				textAlign == ContentAlignment.MiddleRight)
				flags = flags | TextFormatFlags.VerticalCenter;
			else if (textAlign == ContentAlignment.BottomLeft ||
				textAlign == ContentAlignment.BottomCenter ||
				textAlign == ContentAlignment.BottomRight)
				flags = flags | TextFormatFlags.Bottom;
			
			return flags;
		}
	}
}
