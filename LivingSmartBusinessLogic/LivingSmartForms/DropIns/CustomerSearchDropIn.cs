using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivingSmartBusinessLogic;
using LivingSmartBusinessLogic.Controller;
using LivingSmartForms.Classes;
using LivingSmartForms.Views;
using SmartControls;

namespace LivingSmartForms.DropIns
{
	public partial class CustomerSearchDropIn : BaseDropIn
	{
		private CustomerSearchCallback callback;

		private CustomerLineSearch selectedCustomer;

		
		public delegate void CustomerSearchCallback(Customer customer);


		private CustomerSearchDropIn() : base(null)
		{ }

		protected override void Close()
		{
			FinishSearch(null);
		}

		public override string GetDropInId()
		{
			return "CustomerSearch";
		}

		private void Initialize(BaseForm baseForm, CustomerSearchCallback callback)
		{
			this.baseForm = baseForm;
			this.callback = callback;

			InitializeComponent();

			btnSelect.Enabled = false;

			baseForm.ShowDropIn(this);
		}

		public static void Show(BaseForm baseForm, CustomerSearchCallback callback)
		{
			CustomerSearchDropIn dropIn = new CustomerSearchDropIn();
			dropIn.Initialize(baseForm, callback);
		}

		private void FinishSearch(Customer customer)
		{
			baseForm.CloseDropIn();
			callback(customer);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			FinishSearch(null);
		}
		private void btnSelect_Click(object sender, EventArgs e)
		{
			FinishSearch(selectedCustomer.Customer);
		}

		#region Search

		public void SelectCustomer(CustomerLineSearch customer)
		{
			if (selectedCustomer != null)
				selectedCustomer.BackColor = default(Color);
			customer.BackColor = SmartColor.DarkA10;
			selectedCustomer = customer;
			btnSelect.Enabled = true;
		}

		public void FastSelectCustomer(CustomerLineSearch customerLine)
		{
			FinishSearch(customerLine.Customer);
		}

		private void Search(object sender, EventArgs e)
		{
			selectedCustomer = null;
			btnSelect.Enabled = false;
			UpdateResult();
		}

		private void UpdateResult()
		{
			clsResult.ClearList();

			var id = (string.IsNullOrEmpty(stbId.Text)) ? -1 : Convert.ToInt32(stbId.Text);
			var name = (string.IsNullOrEmpty(stbName.Text)) ? null : stbName.Text;
			var address = (string.IsNullOrEmpty(stbAddress.Text)) ? null : stbAddress.Text;
			var phone = (string.IsNullOrEmpty(stbPhone.Text)) ? null : stbPhone.Text;
			var email = (string.IsNullOrEmpty(stbEmail.Text)) ? null : stbEmail.Text;
			var zipcode = (string.IsNullOrEmpty(stbZipCode.Text)) ? -1 : Convert.ToInt32(stbZipCode.Text);

			if(name == null && address == null && phone == null && email == null && zipcode == -1)
				return;

			var result = CustomerController.Instance.SearchCustomers(id, name, address, zipcode, phone, email);

			clsResult.SuspendLayout();

			foreach (var customerLine in result)
				clsResult.AddControl(new CustomerLineSearch(this, customerLine), true);

			clsResult.ResumeLayout();

		}

		#endregion

	}
}
