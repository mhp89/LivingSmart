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
	public partial class SelectableControlList : FlowLayoutPanel
	{
		public Control Selected;

		public SelectableControlList()
		{
			InitializeComponent();

			FlowDirection = FlowDirection.TopDown;
			AutoScroll = true;

			Layout += ControlList_Layout;
			Scroll += ControlList_Scroll;
			MouseEnter += ControlList_MouseEnter;
			MouseWheel += ControlList_MouseWheel;
		}

		void ControlList_MouseWheel(object sender, MouseEventArgs e)
		{
			Console.WriteLine(e.Y);
		}

		void ControlList_MouseEnter(object sender, EventArgs e)
		{
			Focus();
		}

		void ControlList_Scroll(object sender, ScrollEventArgs e)
		{
			Refresh();
		}

		void ControlList_Layout(object sender, LayoutEventArgs e)
		{
			FixControlsWidth();
		}
		
		private void FixControlsWidth()
		{
			if (Controls.Count == 0)
				return;

			SuspendLayout();

			Controls[0].Dock = DockStyle.None;
			Controls[0].Width = DisplayRectangle.Width - Controls[0].Margin.Horizontal;

			for (int i = 1; i < Controls.Count; i++)
				Controls[i].Dock = DockStyle.Top;

			ResumeLayout(true);
		}


		public void AddControl(Control control)
		{

			control.MouseEnter += ControlList_MouseEnter;
			control.MouseWheel += ControlList_MouseWheel;
			control.Click += Control_Click;

			Controls.Add(control);

			FixControlsWidth();
		}

		void Control_Click(object sender, EventArgs e)
		{
			Selected.BackColor = SystemColors.Control;

			Selected = sender as Control;
			
			Selected.BackColor = SmartColor.DarkA25;
		}
	}
}
