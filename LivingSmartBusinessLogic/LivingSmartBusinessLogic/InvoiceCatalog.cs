using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class InvoiceCatalog
    {
        private List<Invoice> invoices;

        public Invoice Check(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Save(Invoice invoice)
        {
            throw new System.NotImplementedException();
        }

        public void AddToCatalog(Invoice invoice)
        {
            invoices.Add(invoice);
        }

        public void RemoveFromCatalog(Invoice invoice)
        {
            invoices.Remove(invoice);
        }
    }
}
