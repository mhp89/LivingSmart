using System.Collections.Generic;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Catalog
{
    internal class InvoiceCatalog
    {
        private List<Invoice> invoices;

        internal Invoice Check(int id)
        {
            throw new System.NotImplementedException();
        }

        internal void Save(Invoice invoice)
        {
            throw new System.NotImplementedException();
        }

        internal void AddToCatalog(Invoice invoice)
        {
            invoices.Add(invoice);
        }

        internal void RemoveFromCatalog(Invoice invoice)
        {
            invoices.Remove(invoice);
        }
    }
}
