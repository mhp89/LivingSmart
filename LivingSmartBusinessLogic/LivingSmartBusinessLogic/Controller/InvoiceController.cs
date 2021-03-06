using LivingSmartBusinessLogic.Entity;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Controller
{
    /// <summary>
    /// Hold the information for an InvoiceController.
    /// </summary>
    public class InvoiceController
	{
		#region Singleton

		private static InvoiceController _instance;
		public static InvoiceController Instance
		{
			get { return _instance ?? (_instance = new InvoiceController()); }
		}

		#endregion

        private InvoiceCatalog invoiceCatalog;

        private InvoiceController()
        {
            invoiceCatalog = new InvoiceCatalog();
        }

        #region Methods

        public void AddInvoice(Invoice invoice)
        {
            invoiceCatalog.AddToCatalog(invoice);
        }

        public Invoice MakeNewInvoice()
        {
            return new Invoice();
        }

        public Invoice ReadInvoice(int id)
        {
            return invoiceCatalog.Check(id);
        }

        public void UpdateInvoice(Invoice invoice)
        {
            invoiceCatalog.Save(invoice);
        }

        #endregion
    }
}
