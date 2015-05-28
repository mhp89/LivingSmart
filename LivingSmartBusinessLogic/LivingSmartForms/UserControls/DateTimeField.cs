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
    public partial class DateTimeField : UserControl
    {
		public DateTimeField()
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

		    var time = stbTime.Text.Split(':');
			var hour = Convert.ToInt32(time[0]);
			var minute = Convert.ToInt32(time[1]);

			var date = new DateTime(year, month, day, hour, minute, 0);

		    return date;
	    }

	    public bool Validate()
		{
			bool fielddataOk = true;

			fielddataOk &= stbDateDay.Validate();
			fielddataOk &= stbDateMonth.Validate();
			fielddataOk &= stbDateYear.Validate();
			fielddataOk &= stbTime.Validate();

			return fielddataOk;
	    }
    }
}
