using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LivingSmartForms.Classes
{
    /// <summary>
    /// Klasse med metoder til opbygning af udskriftsfil
    /// </summary>
    /// <author>Mathias Petersen</author>
    internal static class DocumentGenerator
    {
        private const int PageWidth = 90;
        private const char TopBorderChar = '−';
        private const char SideBorderChar = '|';
        private const char BottomBorderChar = '−';
        private const int DefaultPadding = 2;

        #region Document methods

        /// <summary>
        /// Laver en linje i dokumentets bredde bestående af TopBorderChar
        /// </summary>
        /// <returns></returns>
        internal static string CreateHeaderLine()
        {
            string line = "";

            for (int i = 0; i < PageWidth; i++)
                line += TopBorderChar;

            return line;
        }
        /// <summary>
        /// Laver en linje i dokumentets bredde bestående af BottomBorderChar
        /// </summary>
        /// <returns></returns>
        internal static string CreateFooterLine()
        {
            string line = "";

            for (int i = 0; i < PageWidth; i++)
                line += BottomBorderChar;

            return line;
        }

        /// <summary>
        /// Sørger for at teksten står centreret baseret på sidens bredde
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        internal static string CenteredText(string text)
        {
            string line = SideBorderChar + "";

            line += Spacing((PageWidth - 2 - text.Length) / 2);
            line += text;

            while (line.Length < PageWidth - 1)
                line += " ";

            line += SideBorderChar + Environment.NewLine;

            return line;
        }
        /// <summary>
        /// Laver en tom linje og indsætter SideBorderChar i hver side
        /// </summary>
        /// <returns></returns>
         internal static string EmptyLine()
        {
            string line = SideBorderChar + "";

            line += Spacing(PageWidth - 2);
            line += SideBorderChar + Environment.NewLine;

            return line;
        }
        /// <summary>
        /// Laver en linje i dokumentets bredde af en char defineret i input
        /// </summary>
        /// <param name="fill"></param>
        /// <param name="padding"></param>
        /// <returns></returns>
        internal static string FilledLine(char fill = '-', int padding = DefaultPadding)
        {
            string line = SideBorderChar + "";

            line += Spacing(padding);

            for (int i = 0; i < PageWidth - 2 - (padding * 2); i++)
                line += fill;

            line += Spacing(padding);
            line += SideBorderChar + Environment.NewLine;

            return line;
        }
        /// <summary>
        /// Sørger for teksten står til venstre og indsætter SideBorderChar i hver side
        /// </summary>
        /// <param name="text"></param>
        /// <param name="padding"></param>
        /// <returns></returns>
        internal static string LeftSideText(string text, int padding = DefaultPadding)
        {
            string line = SideBorderChar + "";

            line += Spacing(padding);
            line += text;
            line += Spacing(PageWidth - 2 - padding - text.Length);
            line += SideBorderChar + Environment.NewLine;

            return line;
        }
        /// <summary>
        /// Sørger for teksten står til højre og indsætter SideBorderChar i hver side
        /// </summary>
        /// <param name="text"></param>
        /// <param name="padding"></param>
        /// <returns></returns>
        internal static string RightSideText(string text, int padding = DefaultPadding)
        {
            string line = SideBorderChar + "";

            line += Spacing(PageWidth - 2 - padding - text.Length);
            line += text;
            line += Spacing(padding);
            line += SideBorderChar + Environment.NewLine;

            return line;
        }
        /// <summary>
        /// Gøre det muligt at indsætte tekst i både højre og venstre side
        /// </summary>
        /// <param name="leftText"></param>
        /// <param name="rightText"></param>
        /// <param name="padding"></param>
        /// <returns></returns>
        internal static string BothSideText(string leftText, string rightText, int padding = DefaultPadding)
        {
            string line = SideBorderChar + "";

            line += Spacing(padding);
            line += leftText;
            line += Spacing(PageWidth - 2 - (padding * 2) - leftText.Length - rightText.Length);
            line += rightText;
            line += Spacing(padding);
            line += SideBorderChar + Environment.NewLine;

            return line;
        }

        /// <summary>
        /// Definerer automatisk bredden på kolonner
        /// </summary>
        /// <param name="columns"></param>
        /// <param name="padding"></param>
        /// <returns></returns>
        internal static string AutoSizeMultiColumnstext(string[] columns, int padding = DefaultPadding)
        {
            string line = SideBorderChar + "";
            int actualWidth = PageWidth - 2 - (padding * 2);
            int columnWidth = actualWidth / columns.Length;

            line += Spacing(padding);

            foreach (string text in columns)
            {
                line += text;
                line += Spacing(columnWidth - text.Length);
            }

            line += Spacing(padding);
            line += SideBorderChar + Environment.NewLine;

            return line;

        }
        /// <summary>
        /// Manuel definering af kolonnebredde med klassen Column
        /// </summary>
        /// <param name="columns"></param>
        /// <param name="padding"></param>
        /// <returns></returns>
        internal static string FixedMultiColumnstext(Column[] columns, int padding = DefaultPadding)
        {
            string line = SideBorderChar + "";
            int actualWidth = PageWidth - 2 - (padding * 2);

            line += Spacing(padding);

            int printedWidth = 0;
            foreach (Column column in columns)
            {
                line += column.Text;
                int width = (actualWidth * column.Width / 100);
                line += Spacing(width - column.Text.Length);

                printedWidth += width;
            }

            line += Spacing(actualWidth - printedWidth);
            line += Spacing(padding);
            line += SideBorderChar + Environment.NewLine;

            return line;
        }

        /// <summary>
        /// Indsætter et input defineret antal mellemrum
        /// </summary>
        /// <param name="spacingWidth"></param>
        /// <returns></returns>
        internal static string Spacing(int spacingWidth)
        {
            string spacing = "";
            for (int i = 0; i < spacingWidth; i++)
                spacing += " ";
            return spacing;
        }

        #endregion

        /// <summary>
        /// Definerer tekst og bredde til en kolonne
        /// </summary>
        internal class Column
        {
            public string Text { get; private set; }
            public int Width { get; private set; }  //Kolonnebredde i %

            public Column(string text, int width)
            {
                Text = text;
                Width = width;
            }
        }
    }
}
