using System.Drawing;
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
        public void SetUpDataGridViewHeaderString(DataGridView dataGrid, string Header)
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

        /// <summary>
        /// Settiamo il colore dell'intestazione della tabella e l'utente non inserisce nuove righe
        /// </summary>
        /// <param name="dataGrid"></param>
        public void SetupDataGridViewHeaderColor(DataGridView dataGrid)
        {
            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.Lime;
            dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGrid.EnableHeadersVisualStyles = false;

            dataGrid.AllowUserToAddRows = false;
            dataGrid.Rows.Add();
        }

        /// <summary>
        /// Settiamo la struttura delle proprietà della dataGridView
        /// </summary>
        /// <param name="dataGridElement"></param>
        public void SetDataGrid(DataGridView dataGridElement)
        {
            dataGridElement.AllowUserToAddRows = false;
            dataGridElement.ReadOnly = true;
            dataGridElement.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
