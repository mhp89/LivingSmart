using System.Collections.Generic;
using LivingSmartBusinessLogic.Entity;

namespace LivingSmartBusinessLogic.Model
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
			//if (invoice.Id == -1)
				//Create
			//else
				//Update
        }

        internal void AddToCatalog(Invoice invoice)
        {
			if(!invoices.Contains(invoice))
				invoices.Add(invoice);
        }

        internal void RemoveFromCatalog(Invoice invoice)
        {
            invoices.Remove(invoice);
        }
    }
}
