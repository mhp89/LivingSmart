using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class InvoiceCatalog
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
            invoices.Add(invoice);
        }

        internal void RemoveFromCatalog(Invoice invoice)
        {
            invoices.Remove(invoice);
        }
    }
}
