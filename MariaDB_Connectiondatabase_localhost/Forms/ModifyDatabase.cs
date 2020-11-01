using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MariaDB
{
    public partial class ModifyDatabase : Form
    {
        DataGridViewConfiguration dtg = new DataGridViewConfiguration();
        QueryDatabase qdb = new QueryDatabase();
        ValueConstant valCost = new ValueConstant();

        string tableName; //Nome della tabella dove effettuare le modifiche
        string query;
        string valueElement = " VALUES ";

        public ModifyDatabase(string tableName_, string header, string labelHeader)
        {
            tableName = tableName_;

            InitializeComponent();
            dtg.SetUpDataGridViewHeaderString(dataGridTable, header);
            dtg.SetupDataGridViewHeaderColor(dataGridTable);

            this.InformationtoolStripLabel.Text = labelHeader +tableName_;
            query = labelHeader + tableName_;
        }

        private void SavetoolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(valCost.save, valCost.saveinfo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (res == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridTable.Columns.Count; i++)
                {
                    if (i == 0)
                    {
                        query += " (";
                        valueElement += " (";
                    }

                    query += dataGridTable.Columns[i].Name.ToString();
                    valueElement += dataGridTable.Rows[0].Cells[i].Value.ToString();

                    if (i < dataGridTable.Columns.Count - 1)
                    {
                        query += ",";
                        valueElement += ",";
                    }
                    if (i == dataGridTable.Columns.Count - 1)
                    {
                        query += ")";
                        valueElement += ")";
                    }
                }
                query += valueElement;



            }
        }
    }
}
