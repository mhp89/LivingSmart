using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartControls
{
	public partial class ControlList : FlowLayoutPanel
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new ControlCollection Controls
		{
			get { return base.Controls; }
		}

		public ControlList()
		{
			InitializeComponent();

			FlowDirection = FlowDirection.TopDown;
			AutoScroll = true;
			WrapContents = false;

			Layout += ControlList_Refresh;
			Scroll += ControlList_Refresh;
			SizeChanged += ControlList_Refresh;
			MouseWheel += ControlList_MouseWheel;
			MouseEnter += ControlList_MouseEnter;
		}

		void ControlList_Refresh(object sender, EventArgs e)
		{
			FixControlsWidth();
			Refresh();
		}

		void ControlList_MouseWheel(object sender, MouseEventArgs e)
		{
			if (e.Delta > 0)
			{
				VerticalScroll.Value = (VerticalScroll.Value - 1 >= VerticalScroll.Minimum)
					? VerticalScroll.Value - 1
					: VerticalScroll.Minimum;
			}
			else
			{
				VerticalScroll.Value = (VerticalScroll.Value + 1 <= VerticalScroll.Maximum)
					? VerticalScroll.Value + 1
					: VerticalScroll.Maximum;
			}
		}
		void ControlList_MouseEnter(object sender, EventArgs e)
		{
			//S�tter focus p� control'et s� den kan kalde mousewheel event
			((Control)sender).Focus();
		}

		private void BindEvent(Control parent)
		{
			parent.MouseWheel += ControlList_MouseWheel;
			parent.MouseEnter += ControlList_MouseEnter;

			foreach (Control control in parent.Controls)
			{
				BindEvent(control);
			}
		}
		
		private void FixControlsWidth()
		{
			if (Controls.Count == 0)
				return;

			SuspendLayout();

			//Det f�rste element skal manuelt indstilles til at fylde bredden.
			Controls[0].Dock = DockStyle.None;
			//ClientSize.Width er bredden uden scrollbar
			Controls[0].Width = ClientSize.Width - Controls[0].Margin.Horizontal;

			//De andre f�r automatisk den rigtige bredde, n�r de dockes til toppen.
			for (int i = 1; i < Controls.Count; i++)
				Controls[i].Dock = DockStyle.Top;

			ResumeLayout(true);
		}


		public void AddControl(Control control, bool ignoreLayoutUpdate=false)
		{
			BindEvent(control);

			Controls.Add(control);

			if(!ignoreLayoutUpdate)
				FixControlsWidth();
		}

		public void ClearList()
		{
			Controls.Clear();
		}
	}
}
