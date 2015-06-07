using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
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
		private int _points = 12;
		private Color fillColor;

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

		}
		

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

			var center = new Point(Width / 2, Height / 2);

			// Firkanten uret skal tegnes i
			Rectangle rect = new Rectangle(0, 0, Width-1, Height-1);
			
			// Tegner urskiven.
			e.Graphics.FillEllipse(new SolidBrush(fillColor), rect);
			e.Graphics.DrawEllipse(new Pen(ForeColor, 1), rect);
			e.Graphics.FillEllipse(new SolidBrush(ForeColor), 
				new Rectangle(center.X - 3, center.Y - 3, 6, 6));

			//Tegner minutviseren
			Matrix mx = new Matrix();
			mx.RotateAt(minuteRotation, center);
			e.Graphics.Transform = mx;
			e.Graphics.DrawLine(new Pen(ForeColor) {
				Width = 3,
				EndCap = LineCap.Round
			}, 
			center, new Point(center.X, (int) (center.Y - (Height / 2 * .80))));
			e.Graphics.ResetTransform();

			//Tegner timeviseren
			mx = new Matrix();
			mx.RotateAt(hourRotation, center);
			e.Graphics.Transform = mx;
			e.Graphics.DrawLine(new Pen(ForeColor) {
				Width = 3,
				EndCap = LineCap.Round
			}, center, new Point(center.X, (int) (center.Y - (Height / 2 * .55))));
			e.Graphics.ResetTransform();

			//Tegner punkterne i kanten af uret
			for (int i = 0; i <= Points; i++)
			{
				var rot = i * 360 / (Points);
				Matrix mx2 = new Matrix();
				mx2.RotateAt(rot, center);
				e.Graphics.Transform = mx2;
				e.Graphics.DrawLine(new Pen(ForeColor, 1),
					new Point(center.X, 1),
					new Point(center.X, (int) (Height / 2 * .1)));
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

				//Beregner tiden til n�ste minutskift i millisekunder
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
				fillColor = SmartColor.Dark;
			}
			else
			{
				ForeColor = SmartColor.Dark;
				fillColor = SmartColor.Light;
			}
		}
	}
}
