using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic.DBLayer;

namespace LivingSmartBusinessLogic.DB
{
    internal class InvoiceDBMSSQL : IInvoiceDB
    {
        public List<Invoice> ReadInvoices()
        {
            throw new NotImplementedException();
        }

        public void UpdateInvoice(Invoice invoice)
        {
            throw new NotImplementedException();
        }

        public int CreateInvoice(Invoice invoice)
        {
            throw new NotImplementedException();
        }
    }
}
