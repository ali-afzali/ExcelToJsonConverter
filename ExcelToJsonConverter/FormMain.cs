using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ExcelToJsonConverter
{
    public partial class FormMain : Form
    {
        DataSet sourceData;
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ExcelReader excelReader = new ExcelReader();
            sourceData = excelReader.GetDataFromExcelFile();

            if (sourceData != null && sourceData.Tables[0].Columns.Count > 1)
            {
                dgExcel.DataSource = sourceData.Tables[0];
                for (int i = 0; i < sourceData.Tables[0].Columns.Count; i++)
                {
                    dgExcel.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgExcel.Columns[i].Width = (i == 0) ? 380 : 200;
                }
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            int keyColumnNumber = Convert.ToInt32(comboKeyColumnNumber.Text) - 1;
            int ValueColumnNumber = Convert.ToInt32(comboValueColumnNumber.Text) - 1;

            EnumerableToJsonConverter enumerableToJsonConverter = new EnumerableToJsonConverter();
            rtxtJson.Text = enumerableToJsonConverter.convertToJson(sourceData.Tables[0].Rows, keyColumnNumber, ValueColumnNumber);
        }


    }


}
