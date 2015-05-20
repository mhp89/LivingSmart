using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivingSmartBusinessLogic;
using LivingSmartForms.Classes;

namespace LivingSmartForms.Views
{
    public partial class NewCaseStepSeller : CaseStep
    {
        private CaseController caseController;
        public NewCaseStepSeller(CaseController caseController)
        {
            this.caseController = caseController;
            InitializeComponent();
        }

	    public override bool Save()
	    {
	        return true;
	    }

        private bool VerifyFields()
        {
            return true;
        }
    }
}
