using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic;

namespace LivingSmartBusinessLogic.DB
{
    interface IInvoiceDB
    {
        List<Invoice> ReadInvoices();
        void UpdateInvoice(Invoice invoice);
        int CreateInvoice(Invoice invoice);
    }
}
