using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunnyCart.Utilities
{
    internal class ExcelUtils
    {
        public static List<ExcelData> ReadExcelData(string excelFilePath)
        {
            List<ExcelData> excelDataList = new List<ExcelData>();
            Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using (var stream = File.Open(excelFilePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true,
                        }
                    });

                    var dataTable = result.Tables[sheetName];

                    foreach (DataRow row in dataTable.Rows)
                    {
                        SignUP exceldata = new SignUp
                        {
                            FirstName = GetValueOrDefault(row,)
                        };
                        excelDataList.Add(exceldata);
                    }
                }
            }

            return excelDataList;
        }
    }
}
