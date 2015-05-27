namespace LivingSmartBusinessLogic.Controller
{
    public class InvoiceController
	{
		#region Singleton

		private InvoiceController _instance;
		public InvoiceController Instance
		{
			get { return _instance ?? (_instance = new InvoiceController()); }
		}

		#endregion


        private InvoiceCatalog invoiceCatalog;

        public InvoiceController()
        {
            invoiceCatalog = new InvoiceCatalog();
        }

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
    }
}
