using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LivingSmartBusinessLogic.Model
{
    internal static class DocumentGenerator
    {
        private const int PageWidth = 97;
        private const char TopBorderChar = '−';
        private const char SideBorderChar = '|';
        private const char BottomBorderChar = '−';
        private const int DefaultPadding = 3;

        #region Document methods

        internal static string CreateHeaderLine()
        {
            string line = "";

            for (int i = 0; i < PageWidth; i++)
                line += TopBorderChar;

            return line;
        }
        internal static string CreateFooterLine()
        {
            string line = "";

            for (int i = 0; i < PageWidth; i++)
                line += BottomBorderChar;

            return line;
        }

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
         internal static string EmptyLine()
        {
            string line = SideBorderChar + "";

            line += Spacing(PageWidth - 2);
            line += SideBorderChar + Environment.NewLine;

            return line;
        }
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
        internal static string LeftSideText(string text, int padding = DefaultPadding)
        {
            string line = SideBorderChar + "";

            line += Spacing(padding);
            line += text;
            line += Spacing(PageWidth - 2 - padding - text.Length);
            line += SideBorderChar + Environment.NewLine;

            return line;
        }
        internal static string RightSideText(string text, int padding = DefaultPadding)
        {
            string line = SideBorderChar + "";

            line += Spacing(PageWidth - 2 - padding - text.Length);
            line += text;
            line += Spacing(padding);
            line += SideBorderChar + Environment.NewLine;

            return line;
        }
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

        internal static string Spacing(int spacingWidth)
        {
            string spacing = "";
            for (int i = 0; i < spacingWidth; i++)
                spacing += " ";
            return spacing;
        }

        #endregion

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
