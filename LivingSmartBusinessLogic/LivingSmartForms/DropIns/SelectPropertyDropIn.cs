using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivingSmartBusinessLogic.Controller;
using LivingSmartBusinessLogic.Model;
using LivingSmartForms.Classes;
using LivingSmartForms.DropIns;
using LivingSmartForms.Views;

namespace LivingSmartForms.DropIns
{
    public partial class SelectPropertyDropIn : BaseDropIn
    {
        private PropertySelectCallback callback;

        public delegate void PropertySelectCallback(List<Case> properties);

        public SelectPropertyDropIn(BaseForm baseForm, PropertySelectCallback callback) : base(baseForm)
        {
            this.callback = callback; 
            InitializeComponent();

            UpdateList();
        }

        public override string GetDropInId()
        {
            return "SelectProperty";
        }

        private void UpdateList()
        {
            clsAllProperties.SuspendLayout();

            clsAllProperties.ClearList();
            var properties = CaseController.Instance.GetCases();
            foreach (var property in properties)
            {
                var control = new PropertyLineSelect(this, property);
                control.Margin = Padding.Empty;
                clsAllProperties.AddControl(control, true);
            }

            clsAllProperties.ResumeLayout();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            List<Case> properties = new List<Case>();

            foreach (var control in clsAllProperties.Controls)
            {
                var lineObject = (PropertyLineSelect)control;
                if (lineObject.Selected == true)
                    properties.Add(lineObject.Property);
            }

            callback(properties);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
