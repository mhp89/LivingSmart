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

		/// <summary>
		/// Retunere et DateTime objekt med en gyldig dato.
		/// </summary>
		/// <returns></returns>
	    public DateTime? GetDateTime()
		{
			if (!Validate())
				return null;

		    return GetValidDate();
		}

		/// <summary>
		/// Retunere en dato hvis det indtastede er gyldigt
		/// </summary>
		/// <returns></returns>
	    private DateTime? GetValidDate()
		{
			DateTime? date = null;

			try
			{
				var day = Convert.ToInt32(stbDateDay.Text);
				var month = Convert.ToInt32(stbDateMonth.Text);
				var year = Convert.ToInt32(stbDateYear.Text);

				date = new DateTime(year, month, day);
			}
			catch (Exception) { }

			return date;
	    }

		/// <summary>
		/// Validerer den indtastede dato
		/// </summary>
		/// <returns></returns>
	    public bool Validate()
		{
			bool fielddataOk = true;

			fielddataOk &= stbDateDay.Validate();
			fielddataOk &= stbDateMonth.Validate();
			fielddataOk &= stbDateYear.Validate();

			if(fielddataOk)
				fielddataOk &= GetValidDate() != null;

			return fielddataOk;
	    }

		/// <summary>
		/// Rydder tekstfelterne
		/// </summary>
	    public void ClearDate()
	    {
		    stbDateDay.Text = "";
		    stbDateMonth.Text = "";
		    stbDateYear.Text = "";
	    }

		/// <summary>
		/// S�tter tekstfelterne til en specific dato
		/// </summary>
		/// <param name="date"></param>
	    public void SetDate(DateTime date)
	    {
			stbDateDay.Text = date.Day.ToString();
			stbDateMonth.Text = date.Month.ToString();
			stbDateYear.Text = date.Year.ToString();
	    }

	    public void ClearError()
	    {
			stbDateDay.ClearError();
			stbDateMonth.ClearError();
			stbDateYear.ClearError();
	    }
    }
}
