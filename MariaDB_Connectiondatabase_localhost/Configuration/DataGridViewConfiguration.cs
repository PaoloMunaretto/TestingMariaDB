using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MariaDB
{
    public class DataGridViewConfiguration
    {
        /// <summary>
        /// Settiamo tutte le colonne della nostra DataGridView
        /// </summary>
        /// <param name="dataGrid">dataGridView di riferimento</param>
        /// <param name="Header">Elementi di riferimento Splittati dal Comma (ASCII TABLE 0x2C) </param>
        public void SetUpDataGridWithString(DataGridView dataGrid, string Header)
        {
            dataGrid.Columns.Clear();
            //Carichiamo tutti gli elementi della List<string come colonne di testo
            string[] HeaderItem = Header.Split(','); // Header

            foreach (string item in HeaderItem)
            {
                DataGridViewTextBoxColumn txtcol0 = new DataGridViewTextBoxColumn();
                txtcol0.HeaderText = item;
                txtcol0.Name = item;
                dataGrid.Columns.Add(txtcol0);
            }
        }
    }
}
