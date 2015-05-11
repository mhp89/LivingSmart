using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartControls;

namespace LivingSmartForms
{
    public partial class BaseWindow : Form
    {
        public BaseWindow()
        {
            InitializeComponent();
		}

		private void MenuButtonClick(object sender, EventArgs e)
		{
			MenuButton btn = (MenuButton) sender;

			btn.Selected = !btn.Selected;
		}

		private void BaseWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(Environment.ExitCode);
		}
	}
}
