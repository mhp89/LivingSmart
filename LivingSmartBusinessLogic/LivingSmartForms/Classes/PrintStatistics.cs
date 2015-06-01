using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using LivingSmartBusinessLogic.Controller;
using docGen = LivingSmartForms.Classes.DocumentGenerator;

namespace LivingSmartBusinessLogic.Model
{
    /// <summary>
    /// 
    /// </summary>
    /// <author>Mathias Petersen</author>
    class PrintStatistics
    {
        /// <summary>
        /// Laver udskriftfil med statistik for solgte ejendomme for en bestemt mægler og et bestemt år
        /// </summary>
        /// <param name="fileStream"></param>
        public static void CreatePrintEstateAgent(Stream fileStream, int estateAgentId, int year)
        {
            var list = StatisticsController.Instance.ReadEstateAgentStatistics(estateAgentId, year);

            string page = "";
            string[] headerText = {"Statistik af solgte ejendomme i databasen for en udvalgt mægler og",
                                  "et valgt år vist som summen af salgspriser og antal solgte ejendomme"};

            page += CreateHeader(headerText);

            page += docGen.FixedMultiColumnstext(new[]
			{
				new docGen.Column("Årstal", 25),
				new docGen.Column("Måned", 25),
				new docGen.Column("Salgspris total", 25),
				new docGen.Column("Antal ejendomme", 25)
			});
            page += docGen.FilledLine();

            foreach (Statistics statLine in list)
                page += CreateStatisticsLineEstateAgent(statLine);

            page += docGen.FilledLine();

            //Hvis vi vil udregne total for alle mæglere så skriv det ind her

            page += docGen.EmptyLine();

            page += docGen.CreateFooterLine();

            StreamWriter writer = new StreamWriter(fileStream);
            writer.Write(page);
            writer.Close();
        }
        /// <summary>
        /// Laver udskriftfil med statistik for alle solgte ejendomme i databasen
        /// </summary>
        /// <param name="fileStream"></param>
        public static void CreatePrintAll(Stream fileStream)
        {
            var list = StatisticsController.Instance.ReadAllStatistics();

            string page = "";
            string[] headerText = {"Statistik af alle solgte ejendomme i databasen vist som summen",
                                  "af salgspriser og antal solgte ejendomme pr mægler pr måned"};

            page += CreateHeader(headerText);

            page += docGen.FixedMultiColumnstext(new[]
			{
				new docGen.Column("Årstal", 20),
				new docGen.Column("Måned", 20),
				new docGen.Column("Mægler", 20),
				new docGen.Column("Salgspris total", 20),
				new docGen.Column("Antal ejendomme", 20)
			});
            page += docGen.FilledLine();

            foreach (Statistics statLine in list)
                page += CreateStatisticsLineAll(statLine);

            page += docGen.FilledLine();

            //Hvis vi vil udregne total for alle mæglere så skriv det ind her

            page += docGen.EmptyLine();

            page += docGen.CreateFooterLine();

            StreamWriter writer = new StreamWriter(fileStream);
            writer.Write(page);
            writer.Close();
        }

        /// <summary>
        /// Opretter dokumenthoved til udkriften
        /// </summary>
        /// <returns></returns>
        private static string CreateHeader(string[] textLine)
        {
            string header = "";

            header += docGen.CreateHeaderLine();
            header += Environment.NewLine;

            header +=
                docGen.EmptyLine() +
                docGen.RightSideText("Udskriftstidspunkt: " + DateTime.Now) +
                docGen.CenteredText("Living Smart Ejendomsmæglere") +
                docGen.EmptyLine();
                foreach (string line in textLine)
                    header += docGen.LeftSideText(line);
            
            header +=    
                docGen.FilledLine('_') +
                docGen.EmptyLine() +
                docGen.EmptyLine();

            return header;
        }

        /// <summary>
        /// Laver linjen til statistiktabellen for en mægler og et år
        /// </summary>
        /// <param name="statisticsLine"></param>
        /// <returns></returns>
        /// <author>Mathias Petersen</author>
        private static string CreateStatisticsLineEstateAgent(Statistics statisticsLine)
        {
            String line = "";

            line += docGen.FixedMultiColumnstext(new[]
			{
				new docGen.Column(statisticsLine.Year.ToString(), 25),
				new docGen.Column(statisticsLine.Month.ToString(), 25),
				new docGen.Column(statisticsLine.SellingpriceTotal.ToString(), 25),
				new docGen.Column(statisticsLine.PropertiesTotal.ToString(), 25)
			});
            return line;
        }

        /// <summary>
        /// Laver linjen til statistiktabellen for alle solgte ejendomme
        /// </summary>
        /// <param name="statisticsLine"></param>
        /// <returns></returns>
        private static string CreateStatisticsLineAll(Statistics statisticsLine)
        {
            String line = "";

            line += docGen.FixedMultiColumnstext(new[]
			{
				new docGen.Column(statisticsLine.Year.ToString(), 20),
				new docGen.Column(statisticsLine.Month.ToString(), 20),
				new docGen.Column(statisticsLine.EstateAgentName, 20),
				new docGen.Column(statisticsLine.SellingpriceTotal.ToString(), 20),
				new docGen.Column(statisticsLine.PropertiesTotal.ToString(), 20)
			});
            return line;
        }
    }
}
