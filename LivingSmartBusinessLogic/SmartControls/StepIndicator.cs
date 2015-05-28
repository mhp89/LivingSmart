using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartControls
{
	public class StepIndicator : Control
	{
		#region Defaults

		protected override Size DefaultSize { get { return new Size(350, 20); } }

		#endregion

		#region Step Appearance

		[Category("Step Appearance")]
		public int CurrentStep
		{
			get { return _currentStep; }
			set { _currentStep = value; if (_currentStep > Steps) _currentStep = Steps; if (_currentStep < 0) _currentStep = 0; Invalidate(); }
		}
		private int _currentStep=0;

		[Category("Step Appearance")]
		public int Steps
		{
			get { return _steps; }
			set { _steps = value; if (_steps < 0) _steps = 0; Invalidate(); }
		}
		private int _steps;

		[Category("Step Appearance")]
		public int StepSize
		{
			get { return _stepSize; }
			set { _stepSize = value; Invalidate(); }
		}
		private int _stepSize=18;

		[Category("Step Appearance")]
		public Color StepCompletedFillColor
		{
			get { return _stepCompletedFillColor; }
			set { _stepCompletedFillColor = value; Invalidate(); }
		}
		private Color _stepCompletedFillColor = SmartColor.Dark;

		[Category("Step Appearance")]
		public Color StepUncompletedFillColor
		{
			get { return _stepUncompletedFillColor; }
			set { _stepUncompletedFillColor = value; Invalidate(); }
		}
		private Color _stepUncompletedFillColor = SmartColor.Light;

		[Category("Step Appearance")]
		public Color StepCompletedBorderColor
		{
			get { return _stepCompletedBorderColor; }
			set { _stepCompletedBorderColor = value; Invalidate(); }
		}
		private Color _stepCompletedBorderColor = SmartColor.Dark;

		[Category("Step Appearance")]
		public Color StepUncompletedBorderColor
		{
			get { return _stepUncompletedBorderColor; }
			set { _stepUncompletedBorderColor = value; Invalidate(); }
		}
		private Color _stepUncompletedBorderColor = SmartColor.Dark;


		[Category("Step Appearance")]
		public Color CurrentStepFillColor
		{
			get { return _currentStepFillColor; }
			set { _currentStepFillColor = value; Invalidate(); }
		}
		private Color _currentStepFillColor = SmartColor.DarkA75;
		[Category("Step Appearance")]
		public Color CurrentStepBorderColor
		{
			get { return _currentStepBorderColor; }
			set { _currentStepBorderColor = value; Invalidate(); }
		}
		private Color _currentStepBorderColor = SmartColor.Dark;



		[Category("Step Appearance")]
		public Color LineUncompletedColor
		{
			get { return _lineUncompletedColor; }
			set { _lineUncompletedColor = value; Invalidate(); }
		}
		private Color _lineUncompletedColor = SmartColor.DarkA75;

		[Category("Step Appearance")]
		public Color LineCompletedColor
		{
			get { return _lineCompletedColor; }
			set { _lineCompletedColor = value; Invalidate(); }
		}
		private Color _lineCompletedColor = SmartColor.Dark;

		[Category("Step Appearance")]
		public int LineWidth
		{
			get { return _lineWidth; }
			set { _lineWidth = value; if (_lineWidth < 0) _lineWidth = 0; Invalidate(); }
		}
		private int _lineWidth;

		[Category("Step Appearance")]
		public int LineThickness
		{
			get { return _lineThickness; }
			set { _lineThickness = value; Invalidate(); }
		}
		private int _lineThickness = 2;


		#endregion

		public StepIndicator()
		{
			DoubleBuffered = true;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

			int drawWidth = (Steps*StepSize) + ((Steps - 1)*LineWidth);

			var offset = new Point((Width-drawWidth)/2, (Height-StepSize)/2);
			
			for (int i = 0; i < Steps; i++)
			{
				var x = StepSize*i;

				x += LineWidth*i - 1;


				if (i < Steps - 1)
				{
					if (i < CurrentStep)
						e.Graphics.DrawLine(new Pen(LineCompletedColor, LineThickness),
							new Point(offset.X + x + StepSize, offset.Y + StepSize / 2),
							new Point(offset.X + x + StepSize + LineWidth, offset.Y + StepSize / 2));
					else
						e.Graphics.DrawLine(new Pen(LineUncompletedColor, LineThickness),
							new Point(offset.X + x + StepSize, offset.Y + StepSize / 2),
							new Point(offset.X + x + StepSize + LineWidth, offset.Y + StepSize / 2));
				}

				if (i == CurrentStep)
				{
					e.Graphics.FillEllipse(new SolidBrush(CurrentStepFillColor), new Rectangle(offset.X + x, offset.Y, StepSize, StepSize));
					e.Graphics.DrawEllipse(new Pen(CurrentStepBorderColor), new Rectangle(offset.X + 1, offset.Y + 1, StepSize - 2, StepSize - 2));
				}
				else if (i < CurrentStep)
				{
					e.Graphics.FillEllipse(new SolidBrush(StepCompletedFillColor), new Rectangle(offset.X+x, offset.Y, StepSize, StepSize));
					e.Graphics.DrawEllipse(new Pen(StepCompletedBorderColor), new Rectangle(offset.X+1, offset.Y+1, StepSize - 2, StepSize - 2));
				}
				else
				{
					e.Graphics.FillEllipse(new SolidBrush(StepUncompletedFillColor), new Rectangle(offset.X + x, offset.Y, StepSize, StepSize));
					e.Graphics.DrawEllipse(new Pen(StepUncompletedBorderColor), new Rectangle(offset.X + x, offset.Y + 1, StepSize - 2, StepSize - 2));
				}
			}
		}
	}
}
