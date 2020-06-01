using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelToJsonConverter
{
    class ExcelReader
    {
        public DataSet GetDataFromExcelFile()
        {
            IExcelDataReader reader = null;
            var conf = new ExcelDataSetConfiguration
            {
                ConfigureDataTable = _ => new ExcelDataTableConfiguration
                {
                    UseHeaderRow = true
                }
            };
            using (OpenFileDialog fileDialog = new OpenFileDialog()
            {
                Filter = "Excel Files|*.xls;*.xlsx",
                ValidateNames = true
            })
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    var stream = File.Open(fileDialog.FileName, FileMode.Open, FileAccess.Read);
                    if (Path.GetExtension(fileDialog.FileName).Equals(".xls"))
                        reader = ExcelReaderFactory.CreateBinaryReader(stream);
                    else if (Path.GetExtension(fileDialog.FileName).Equals(".xlsx"))
                        reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                    else
                    {
                        MessageBox.Show("Invalid File Type");
                        throw new Exception("Invalid FileName");
                    }
                    return reader.AsDataSet(conf);
                }
                return null;
            }
        }
    }
}
