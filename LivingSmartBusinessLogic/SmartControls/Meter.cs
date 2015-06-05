using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GraphicalMeterLibrary
{
	public partial class Meter : Control
	{
		#region Cirlce Properties

		private Color _circleBackColor = Color.White;
		private Color _pointerColor = Color.Black;

		private int _circleSize = 100;
		private int _circlePoints = 10;

		private int _maxValue = 10;
		private int _minValue = 0;
		private int _value = 5;

		[Category("Circle Properties")]
		public Color CircleBackColor
		{
			get { return _circleBackColor; }
			set { _circleBackColor = value; Invalidate(); }
		}
		[Category("Circle Properties")]
		public Color PointerColor
		{
			get { return _pointerColor; }
			set { _pointerColor = value; Invalidate(); }
		}
		[Category("Circle Properties")]
		public int CircleSize
		{
			get { return _circleSize; }
			set { _circleSize = value; Invalidate(); }
		}
		[Category("Circle Properties")]
		public int CirclePoints
		{
			get { return _circlePoints; }
			set { _circlePoints = value; Invalidate(); }
		}

		[Category("Circle Properties")]
		public int MaxValue
		{
			get { return _maxValue; }
			set { _maxValue = value; Invalidate(); }
		}
		[Category("Circle Properties")]
		public int MinValue
		{
			get { return _minValue; }
			set { _minValue = value; Invalidate(); }
		}
		[Category("Circle Properties")]
		public int Value
		{
			get { return _value; }
			set {
				_value = value;
				_rotation = GetRotation();
			}
		}

		#endregion

		protected override Size DefaultSize { get { return new Size(100, 50); } }

		private float _rotation = -90;
		private float _currentRotation;

		private Thread t;

		public Meter()
		{
			InitializeComponent();

			DoubleBuffered = true;

			t = new Thread(Run) {IsBackground = false};
			t.Start();
		}
		
		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

			var topCenter = new Point(Width / 2, Height - (CircleSize / 2));
			var bottomCenter = new Point(Width / 2, Height);

			// Create rectangle to bound ellipse.
			Rectangle rect = new Rectangle((Width - CircleSize) / 2, ((Height - CircleSize) / 2 + (Height / 2)), CircleSize, CircleSize);
			// Draw arc to screen.
			e.Graphics.FillEllipse(new SolidBrush(CircleBackColor), rect);
			e.Graphics.DrawEllipse(new Pen(PointerColor, 1), rect);

			//Draw pointer
			Matrix mx = new Matrix();
			mx.RotateAt(_currentRotation, bottomCenter);
			e.Graphics.Transform = mx;
			e.Graphics.DrawLine(new Pen(PointerColor){Width = 3, EndCap = LineCap.Round}, bottomCenter, new Point(bottomCenter.X, (bottomCenter.Y - (CircleSize/2)+10)));
			e.Graphics.ResetTransform();


			for (int i = 1; i < CirclePoints+1; i++)
			{
				var rot = -90 + (i * 180 / (CirclePoints+1));
				Matrix mx2 = new Matrix();
				mx2.RotateAt(rot, bottomCenter);
				e.Graphics.Transform = mx2;
				e.Graphics.DrawLine(new Pen(PointerColor, 1), topCenter, new Point(topCenter.X, topCenter.Y + 5));
				e.Graphics.ResetTransform();
			}
		}


		private void Run()
		{
			while (true)
			{
				Value = DateTime.Now.Second;
				var step = (_rotation - _currentRotation)/(500/30);
				if (_currentRotation != _rotation)
				{
					_currentRotation += step;
					Invalidate();
				}
				Thread.Sleep(30);
			}
		}

		private float GetRotation()
		{
			float range = MaxValue - MinValue;
			float percent = (Value - MinValue)/range;

			return -90 + (percent * 180);
		}
	}
}
