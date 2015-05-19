using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivingSmartBusinessLogic;

namespace TestTest
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseController caseController = new CaseController();

            Case newCase = caseController.MakeNewCase();

            caseController.AddCase(newCase);

            

            for (int i = 0; i < 10; i++)
            {
                caseController.AddAdToCase(newCase, new Ad());
            }

            ReadOnlyCollection<Ad> ads = newCase.GetAds();
            

            ads = newCase.GetAds();

            foreach (var ad in ads)
            {
                Console.WriteLine(ad.Type);
            }


            /*
            #region MyRegion

            List<Case> cases = new List<Case>();

            Case newCase = new Case();

            cases.Add(newCase);

            foreach (var cCase in cases)
            {
                Console.WriteLine(cCase);
            }

            #endregion
            */

            Console.ReadKey();
        }
    }
}
