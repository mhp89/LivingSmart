using System;
using System.Collections.ObjectModel;
using LivingSmartBusinessLogic.Entity;
using docGen = LivingSmartForms.Classes.DocumentGenerator;

namespace LivingSmartForms.Classes
{
    /// <summary>
    /// 
    /// </summary>
    /// <author>Mathias Petersen</author>
	class PrintInvoice
    {
        /// <summary>
        /// Laver udskriftfil med fakturaen for en case
        /// </summary>
        public static string CreatePrintInvoice(Case cCase, ReadOnlyCollection<Document> documents, double feeTotal)
        {
            string page = "";

            page += CreateHeader(cCase);

            page += docGen.FixedMultiColumnstext(new[]
			{
				new DocumentGenerator.Column("Beskrivelse", 65),
				new DocumentGenerator.Column("Pris", 35)
			});
            page += docGen.FilledLine();


	        double price = feeTotal;
			page += CreateItemLine("Salær", feeTotal);
	        foreach (Document document in documents)
	        {
				if(document.Price == 0) continue;
		        
		        price += document.Price;
		        page += CreateItemLine(document.Type, document.Price);
	        }

	        page += docGen.FilledLine();

			page += CreateItemLine("I alt ekskl. moms", price);
			page += CreateItemLine("Moms (25%)", price * .25);
			page += CreateItemLine("I alt inkl. moms", price*1.25);

            page += docGen.EmptyLine();

            page += docGen.CreateFooterLine();

            return page;
        }

        /// <summary>
        /// Opretter dokumenthoved til udkriften
        /// </summary>
        /// <returns></returns>
        private static string CreateHeader(Case cCase)
        {
            string header = "";

            header += docGen.CreateHeaderLine();
            header += Environment.NewLine;

			header +=
				docGen.EmptyLine() +
				docGen.RightSideText("Udskriftstidspunkt: " + DateTime.Now) +
				docGen.EmptyLine() +
				docGen.BothSideText(cCase.Seller.Name, "Living Smart") +
				docGen.BothSideText(cCase.Seller.Address, "Strandvejen 18") +
				docGen.BothSideText(cCase.Seller.City.NiceDisplay, "7100 Vejle") +
				docGen.BothSideText("Danmark", "Danmark") +
				docGen.EmptyLine() +
				docGen.RightSideText("CVR-nr.: 12345678") +
				docGen.RightSideText("Tlf.: 12345678") +
				docGen.BothSideText("Sagsnr.: " + cCase.Id, "kontakt@livingSmart.dk") +
				docGen.FilledLine('_') +
				docGen.EmptyLine() +
				docGen.EmptyLine();

            return header;
        }

		private static String CreateItemLine(string type, double price)
		{
			String line = "";

			line += docGen.FixedMultiColumnstext(new[]
			{
				new DocumentGenerator.Column(type, 65),
				new DocumentGenerator.Column(price.ToString("C"), 35)
			});
			return line;
		}
    }
}
