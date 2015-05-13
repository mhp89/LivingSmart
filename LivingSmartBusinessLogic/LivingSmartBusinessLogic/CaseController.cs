using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class CaseController
    {
        private CaseCatalog caseCatalog;
        public void AddCase(Case newCase)
        {
            caseCatalog.AddToCatalog(newCase);
        }

        public Case MakeNewCase()
        {
            return new Case();
        }

        public Case ReadCase(int id)
        {
            return caseCatalog.Check(id);
        }

        public void UpdateCase()
        {
            throw new System.NotImplementedException();
        }
    }
}
