using System.Collections.Generic;
using ClosedXML.Excel;

namespace WalkPageGen
{
    public class ExcelReader
    {
        private readonly string workbookName;
        private readonly string worksheetName;

        public ExcelReader(string book, string sheet)
        {
            workbookName = book;
            worksheetName = sheet;
        }

        public List<string> GetColumnHeaders()
        {
            var worksheet = OpenWorksheet();
            var row = worksheet.FirstRowUsed().RowNumber();
            var col = worksheet.FirstColumnUsed().ColumnNumber();
            var headers = new List<string>();

            while (true)
            {
                var value = (string)worksheet.Cell(row, col).Value;
                if (string.IsNullOrWhiteSpace(value))
                    break;

                headers.Add(value);
                col++;
            }

            return headers;
        }

        public List<List<object>> ReadRangeValues(string range)
        {
            var worksheet = OpenWorksheet();
            var worksheetRange = worksheet.Range(range);
            var values = new List<List<object>>();

            foreach (var row in worksheetRange.Rows())
            {
                var rowValues = new List<object>();
                foreach(var cell in row.Cells())
                {
                    rowValues.Add(cell.Value);
                }
                values.Add(rowValues);
            }
            return values;
        }

        private IXLWorksheet OpenWorksheet()
        {
            var workbook = new XLWorkbook(workbookName);
            return workbook.Worksheet(worksheetName);
        }
    }
}
