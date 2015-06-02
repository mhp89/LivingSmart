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
	public partial class ControlCurtain : FlowLayoutPanel
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public new ControlCollection Controls
		{
			get { return base.Controls; }
		}

        public int Spacing { get { return _spacing; } set { _spacing = value; } }
        private int _spacing = 5;

		public ControlCurtain()
		{
			InitializeComponent();

			FlowDirection = FlowDirection.LeftToRight;
			AutoScroll = true;
			WrapContents = false;

			Layout += ControlCurtain_Refresh;
			Scroll += ControlCurtain_Refresh;
			SizeChanged += ControlCurtain_Refresh;
			MouseWheel += ControlCurtain_MouseWheel;
			MouseEnter += ControlCurtain_MouseEnter;
		}

		void ControlCurtain_Refresh(object sender, EventArgs e)
		{
			FixControlsHeight();
			Refresh();
		}

		void ControlCurtain_MouseWheel(object sender, MouseEventArgs e)
		{
			if (e.Delta > 0)
			{
				HorizontalScroll.Value = (HorizontalScroll.Value - 1 >= HorizontalScroll.Minimum)
					? HorizontalScroll.Value - 1
					: HorizontalScroll.Minimum;
			}
			else
			{
                HorizontalScroll.Value = (HorizontalScroll.Value + 1 <= HorizontalScroll.Maximum)
                    ? HorizontalScroll.Value + 1
                    : HorizontalScroll.Maximum;
			}
		}
		void ControlCurtain_MouseEnter(object sender, EventArgs e)
		{
			//Sætter focus på control'et så den kan kalde mousewheel event
			((Control)sender).Focus();
		}

		private void BindEvent(Control parent)
		{
			parent.MouseWheel += ControlCurtain_MouseWheel;
			parent.MouseEnter += ControlCurtain_MouseEnter;

			foreach (Control control in parent.Controls)
			{
				BindEvent(control);
			}
		}
		
		private void FixControlsHeight()
		{
			if (Controls.Count == 0)
				return;

			SuspendLayout();

			//Det første element skal manuelt indstilles til at fylde højden.
			Controls[0].Dock = DockStyle.None;
			//ClientSize.Height er højden uden scrollbar
			Controls[0].Height = ClientSize.Height - Controls[0].Margin.Vertical;

			//De andre får automatisk den rigtige højde, når de dockes til venstre.
            for (int i = 1; i < Controls.Count; i++)
            {
                Controls[i].Dock = DockStyle.Left;
                Controls[i].Margin = new Padding(Spacing, 0, 0, 0);
            }

			ResumeLayout(true);
		}

		public void AddControl(Control control, bool ignoreLayoutUpdate=false)
		{
			BindEvent(control);

			Controls.Add(control);

			if(!ignoreLayoutUpdate)
				FixControlsHeight();
		}

        public void RemoveControl(Control control, bool ignoreLayoutUpdate = false)
        {
            Controls.Remove(control);

            if (!ignoreLayoutUpdate)
                FixControlsHeight();
        }

		public void ClearList()
		{
			Controls.Clear();
		}
	}
}
