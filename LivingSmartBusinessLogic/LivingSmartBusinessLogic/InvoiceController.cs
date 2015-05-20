using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class InvoiceController
    {
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
