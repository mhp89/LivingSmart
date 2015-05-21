using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartControls
{
	public class AnalogClock : Control
	{
		//Time
		private DateTime time;
		public string Timezone
		{
			get { return _timezone; }
			set { _timezone = value; UpdateTime(); }
		}
		private string _timezone = "Romance Standard Time";

		public int Points
		{
			get { return _points; }
			set { _points = value; }
		}
		private int _points = 24;
		private Color FillColor;

		//Clock
		private float minuteRotation;
		private float hourRotation;
		
		//Thread
		private Thread thread;

		#region Defaults

		protected override Size DefaultSize { get { return new Size(100, 100); } }

		#endregion

		public AnalogClock(string timezone)
		{
			Timezone = timezone;

			DoubleBuffered = true;

			if (!DesignMode)
			{
				thread = new Thread(Run);
				thread.IsBackground = false;
				thread.Start();
			}
		}

		public AnalogClock()
		{
			DoubleBuffered = true;

			if (!DesignMode)
			{
				thread = new Thread(Run);
				thread.Start();
			}
		}
		

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

			var center = new Point(Width / 2, Height / 2);

			// Create rectangle to bound ellipse.
			Rectangle rect = new Rectangle(0, 0, Width-1, Height-1);
			// Draw arc to screen.
			e.Graphics.FillEllipse(new SolidBrush(FillColor), rect);
			e.Graphics.DrawEllipse(new Pen(ForeColor, 1), rect);

			//Draw minute pointer
			Matrix mx = new Matrix();
			mx.RotateAt(minuteRotation, center);
			e.Graphics.Transform = mx;
			e.Graphics.DrawLine(new Pen(ForeColor) { Width = 3, EndCap = LineCap.Round }, center, new Point(center.X, (int) (center.Y - (Height / 2 * .80))));
			e.Graphics.ResetTransform();

			//Draw minute pointer
			mx = new Matrix();
			mx.RotateAt(hourRotation, center);
			e.Graphics.Transform = mx;
			e.Graphics.DrawLine(new Pen(ForeColor) { Width = 3, EndCap = LineCap.Round }, center, new Point(center.X, (int) (center.Y - (Height / 2 * .55))));
			e.Graphics.ResetTransform();

			for (int i = 0; i <= Points; i++)
			{
				var rot = i * 360 / (Points);
				Matrix mx2 = new Matrix();
				mx2.RotateAt(rot, center);
				e.Graphics.Transform = mx2;
				e.Graphics.DrawLine(new Pen(ForeColor, 1), new Point(center.X, 1), new Point(center.X, (int) (Height / 2 * .1)));
				e.Graphics.ResetTransform();
			}
		}


		private DateTime GetTime()
		{
			return TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById(Timezone));
		}
		private void UpdateTime()
		{
			var newTime = GetTime();

			if (newTime.Minute != time.Minute || newTime.Hour != time.Hour)
			{
				RotateClock(newTime);
				time = newTime;
			}
		}

		private void Run()
		{
			while (true)
			{
				UpdateTime();

				var delay = (60 - time.Second)*1000;
				Thread.Sleep(delay);
			}
		}

		private void RotateClock(DateTime newTime)
		{
			if (newTime.Minute != time.Minute)
				minuteRotation = 6 * newTime.Minute;

			if (newTime.Hour != time.Hour)
				hourRotation = 30*(newTime.Hour%12) + (newTime.Minute/2);

			bool nightState = newTime.Hour > 20 || newTime.Hour < 8;
			UpdateColor(nightState);
			
			Invalidate();
		}

		private void UpdateColor(bool nightState)
		{
			if (nightState)
			{
				ForeColor = SmartColor.Light;
				FillColor = SmartColor.Dark;
			}
			else
			{
				ForeColor = SmartColor.Dark;
				FillColor = SmartColor.Light;
			}
		}
	}
}
