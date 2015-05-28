using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivingSmartForms.UserControls
{
    public partial class DateField : UserControl
    {
        public DateField()
        {
            InitializeComponent();
        }

	    public DateTime? GetDateTime()
		{
			if (!Validate())
				return null;

			var day = Convert.ToInt32(stbDateDay.Text);
			var month = Convert.ToInt32(stbDateMonth.Text);
			var year = Convert.ToInt32(stbDateYear.Text);

			var date = new DateTime(year, month, day);

		    return date;
	    }

	    public bool Validate()
		{
			bool fielddataOk = true;

			fielddataOk &= stbDateDay.Validate();
			fielddataOk &= stbDateMonth.Validate();
			fielddataOk &= stbDateYear.Validate();

			return fielddataOk;
	    }
    }
}
