using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChallengerFactPlanner
{
    public partial class importEmployees : Form
    {
        public importEmployees()
        {
            InitializeComponent();
        }

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];
            //dataGridView1.DataSource = dt;
            if (dt != null)
            {
                List<Employees> list = new List<Employees>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Employees obj = new Employees();
                    obj.EmployeeID = dt.Rows[i]["EmployeeID"].ToString();
                    obj.FullName = dt.Rows[i]["FullName"].ToString();
                    obj.Specialty = dt.Rows[i]["Specialty"].ToString();
                    list.Add(obj);
                }
                employeesBindingSource.DataSource = list;
            }
        }

        DataTableCollection tableCollection;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtFilename.Text = ofd.FileName;
                    using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow = true
                                }
                            });
                            tableCollection = result.Tables;
                            cboSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cboSheet.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void importEmployees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'challengerDBDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.challengerDBDataSet.Employees);

        }
    }
}
