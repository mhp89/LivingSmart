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

		public int Spacing { get { return _spacing; } set { _spacing = value; } }
		private int _spacing = 5;

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
			//Sætter focus på control'et så den kan kalde mousewheel event
			Focus();
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

			//Pauser layout logikken midlertidigt, af hensyn til performance
			SuspendLayout();

			//Det første element skal manuelt indstilles til at fylde bredden.
			Controls[0].Dock = DockStyle.None;
			//ClientSize.Width er bredden uden scrollbar
			Controls[0].Width = ClientSize.Width - Controls[0].Margin.Horizontal;
			Controls[0].Margin = Padding.Empty;

			//De andre før automatisk den rigtige bredde, når de dockes til toppen.
			for (int i = 1; i < Controls.Count; i++)
			{
				Controls[i].Dock = DockStyle.Top;
				Controls[i].Margin = new Padding(0, Spacing, 0, 0);
			}

			//Genoptager layout logikken
			ResumeLayout(true);
		}


		public void AddControl(Control control, bool ignoreLayoutUpdate=false)
		{
			BindEvent(control);

			Controls.Add(control);

			if(!ignoreLayoutUpdate)
				FixControlsWidth();
		}

		public void RemoveControl(Control control, bool ignoreLayoutUpdate = false)
		{
			Controls.Remove(control);
			
			if (!ignoreLayoutUpdate)
				FixControlsWidth();
		}

		public void ClearList()
		{
			Controls.Clear();
		}
	}
}
