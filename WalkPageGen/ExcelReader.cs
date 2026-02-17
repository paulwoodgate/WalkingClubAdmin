using System.Collections.Generic;
using System.Linq;
using ClosedXML.Excel;

namespace WalkPageGen
{
    public class ExcelReader(string book, string sheet)
    {
        private readonly string workbookName = book;
        private readonly string worksheetName = sheet;

        public List<string> GetColumnHeaders()
        {
            var worksheet = OpenWorksheet();
            var row = worksheet.FirstRowUsed().RowNumber();
            var col = worksheet.FirstColumnUsed().ColumnNumber();
            var headers = new List<string>();

            while (true)
            {
                var value = worksheet.Cell(row, col).Value;
                if (value.IsBlank)
                    break;

                headers.Add((string)value);
                col++;
            }

            return headers;
        }

        public List<List<object>> ReadRangeValues(string range)
        {
            var worksheet = OpenWorksheet();
            var worksheetRange = worksheet.Range(range);
            var values = new List<List<object>>();
            var lastRowUsed = worksheet.LastRowUsed().RowNumber();

            foreach (var row in worksheetRange.Rows().Where(r => r.RowNumber() <= lastRowUsed))
            {

                var rowValues = new List<object>();
                foreach (var cell in row.Cells())
                {
                    rowValues.Add(cell.Value.ToString());
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
