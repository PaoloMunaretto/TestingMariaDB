using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlServerConnections;
using MySql.Data.MySqlClient;

namespace MariaDB
{
    public partial class Start : Form
    {
        readonly DataGridViewConfiguration dataGridConfig = new DataGridViewConfiguration();
        readonly ValueConstant valConst = new ValueConstant();
        readonly QueryDatabase queryDB = new QueryDatabase();

        public string stringConnection = ""; //Connettersi al database


        public Start()
        {
            InitializeComponent();
            stringConnection = "server=" + valConst.nameServer + ";port=" + valConst.port + ";Database=" + valConst.databaseName + ";uid=" + valConst.nameUser + ";password=" + valConst.password;

            dataGridElement.AllowUserToAddRows = false;
            panelButtons.Enabled = false;

            valConst.SetTablesArray(queryDB.ReadAllTablesMariaDB(stringConnection, valConst.readAllTableDB));

            foreach (string item in valConst.arrTable)
            {
                if (item.Length > 2)
                    cbTable.Items.Add(item);
            }
        }


        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------  Events used in this class
        //-----------------------------------------------------------------------------------------------------

        /// <summary>
        /// Visualizziamo tutti gli elementi della tabella
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Connection_Click(object sender, EventArgs e)
        {
            string query = valConst.readTableDB + cbTable.Text;

            DataTable table = queryDB.GetValues(stringConnection, query);

            SetTableInDataGrid(dataGridElement, table);
            if (cbTable.Text.Length > 1)
            {
                panelButtons.Enabled = true;
            }
        }

        /// <summary>
        /// Prendiamo l'oggetto selezionando la riga della DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridElement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // if (cbTable.Text.CompareTo("city") == 0) //city
            {
                try
                {
                    City cityObj = new City();
                    DataRow row = (dataGridElement.SelectedRows[0].DataBoundItem as DataRowView).Row;
                    cityObj = (City)row;
                    MessageBox.Show(cityObj.CityName + " : " + cityObj.ReferenceContry + " - " + cityObj.Country.CountryName, valConst.titleReferenceMSG);
                    return; //l'elemento selezionato è una città, concludiamo l'evento
                }
                catch (Exception ex)
                {
                   
                }
            }

            // if (cbTable.Text.CompareTo("country") == 0) //contry
            {
                try
                {
                    Country contryObj = new Country();
                    DataRow row = (dataGridElement.SelectedRows[0].DataBoundItem as DataRowView).Row;
                    contryObj = (Country)row;
                    MessageBox.Show(contryObj.Capital + " : " + contryObj.CountryName, valConst.titleReferenceMSG);
                    return;//l'elemento selezionato è uno stato, chiudiamo l'evento
                }
                catch (Exception ex)
                {
                   
                }
            }
        }

        /// <summary>
        /// Inseriamo un nuovo elemento nel Database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btInsert_Click(object sender, EventArgs e)
        {
            //Apriamo un nuovo Form per inserire un nuovo elemento
            ModifyDatabase modify = new ModifyDatabase(cbTable.Text, GetNameAndTypeColum(dataGridElement), valConst.insertDB, stringConnection);
            modify.ShowDialog();
        }

        /// <summary>
        /// Visualizziamo il nuovo valore ID se vogliamo inserire un nuovo elemento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNewID_Click(object sender, EventArgs e)
        {
            //Visualizziamo il nuovo valore ID che sarà da inserire per un nuovo elemento
            MessageBox.Show("NEW ID ELEMENT : " + queryDB.GetNewId(stringConnection, cbTable.Text, dataGridElement.Columns[0].Name).ToString(), "NEW ID");
        }

        /// <summary>
        /// Modifichiamo un elemento nel nostro database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btModify_Click(object sender, EventArgs e)
        {
            //Apriamo un nuovo Form per modificare l'elemento selezionato
            ModifyDatabase modify = new ModifyDatabase(cbTable.Text, GetNameAndTypeColum(dataGridElement), valConst.updateDB, stringConnection);
            //modify.FirstValueReadOnly = true;
            modify.ShowDialog();
        }

        /// <summary>
        /// Eliminiamo un elemento dal nostro database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(valConst.deleteQuestionMSG, valConst.sureQuestionMSG, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            string query = valConst.deleteDB + cbTable.Text + valConst.whereDB + dataGridElement.Columns[0].Name + " ='" + dataGridElement.SelectedRows[0].Cells[0].Value.ToString() + "';";
            queryDB.InsertElement(stringConnection, query);
        }


        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------  Metod used in this class
        //-----------------------------------------------------------------------------------------------------

        /// <summary>
        /// Incapsuliamo l'origine dei dati alla DataSource per la DataGridView
        /// </summary>
        /// <param name="dataGrid"></param>
        /// <param name="table"></param>
        public void SetTableInDataGrid(DataGridView dataGrid, DataTable table)
        {
            BindingSource source = new BindingSource();
            source.DataSource = table;
            dataGrid.DataSource = source;
        }




        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------  Metods not used, only for Testing
        //-----------------------------------------------------------------------------------------------------

        /// <summary>
        /// Otteniamo il nome (ed il tipo di elemento)di ogni colonna della tabella
        /// </summary>
        /// <param name="dataGrid"></param>
        public string GetNameAndTypeColum(DataGridView dataGrid)
        {
            StringBuilder st = new StringBuilder();
            for (int i = 0; i < dataGrid.Columns.Count; i++)
            {
                //Otteniamo il nome della colonna ed il valore del tipo di elemento 
                st.Append(dataGrid.Columns[i].Name /*+" " + dataGrid.Columns[i].ValueType.ToString().Replace("System", "")*/);

                if (i < dataGrid.Columns.Count - 1)
                {
                    st.Append(",");
                }
            }
            //MessageBox.Show(st.ToString());
            return st.ToString();
        }

        /// <summary>
        /// Visualizziamo una specifica colonna della tabella di un database
        /// </summary>
        public void showTable()
        {
            MySqlConnection sqlConnection = new MySqlConnection(stringConnection);
            MySqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = "SELECT * FROM " + cbTable.Text;

            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                dataGridElement.Rows.Add(reader["Address"].ToString());
            }


        }

        /// <summary>
        /// Verifichiamo che la connessione sia possibile con la tabella del database
        /// </summary>
        public void verifyConnectionDatabase()
        {

            //connectionString ="Server=____________;Port=__________;Database=_______;Uid=____________;password=______;"

            try
            {
                // Alternativa, separando le attività:
                /*
                sqlConnect = new MySqlConnection();
                sqlConnect.ConnectionString = stringConnection;
                */
                MySqlConnection sqlConnection = new MySqlConnection(stringConnection);
                sqlConnection.Open();
                if (sqlConnection.State == ConnectionState.Open)
                {
                    MessageBox.Show(valConst.connectionOkMSG);
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
