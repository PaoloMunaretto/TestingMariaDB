using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace MariaDB
{
    
    public partial class Start : Form
    {
        readonly DataGridViewConfiguration dataGridConfig = new DataGridViewConfiguration();
        readonly ValueConstant valConst = new ValueConstant();
        readonly QueryDatabase queryDB = new QueryDatabase();

        public Start()
        {
            InitializeComponent();

            // "server=" + valConst.nameServer + ";port=" + valConst.port + ";Database=" + valConst.databaseName + ";uid=" + valConst.nameUser + ";password=" + valConst.password;
            CONSTANTS.stringConnection = String.Format("server= {0}; port= {1}; Database= {2}; uid={3}; password={4}", CONSTANTS.NAME_SERVER, CONSTANTS.PORT, CONSTANTS.DATABASE_NAME, CONSTANTS.NAME_USER, CONSTANTS.PASSWORD);

            dataGridConfig.SetDataGrid(dataGridElement);

            valConst.SetTablesArray(queryDB.ReadAllTablesMariaDB(CONSTANTS.stringConnection, valConst.readAllTableDB));

            foreach (string item in valConst.arrTable)
            {
                if (item.Length > 2)
                    cbTable.Items.Add(item);
            }

            panelButtons.Enabled = false;
            this.Text += CONSTANTS.VERSION_SW;
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

            DataTable table = queryDB.GetValues(CONSTANTS.stringConnection, query);

            SetTableInDataGrid(dataGridElement, table);
            if (cbTable.Text.Length > 1)
            {
                panelButtons.Enabled = true;
            }
        }

        private void BtShow_Click(object sender, EventArgs e)
        {
            SetElement(true);
        }

        /// <summary>
        /// Prendiamo l'oggetto selezionando la riga della DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridElement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetElement(false);
        }

        /// <summary>
        /// Inseriamo un nuovo elemento nel Database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtInsert_Click(object sender, EventArgs e)
        {
            //Apriamo un nuovo Form per inserire un nuovo elemento
            ModifyDatabase modify = new ModifyDatabase(cbTable.Text, GetNameAndTypeColum(dataGridElement), valConst.insertDB, CONSTANTS.stringConnection, null);
            modify.ShowDialog();
        }

        /// <summary>
        /// Visualizziamo il nuovo valore ID se vogliamo inserire un nuovo elemento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtNewID_Click(object sender, EventArgs e)
        {
            //Visualizziamo il nuovo valore ID che sarà da inserire per un nuovo elemento
            MessageBox.Show("NEW ID ELEMENT : " + queryDB.GetNewId(CONSTANTS.stringConnection, cbTable.Text, dataGridElement.Columns[0].Name).ToString(), "NEW ID");
        }

        /// <summary>
        /// Modifichiamo un elemento nel nostro database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtModify_Click(object sender, EventArgs e)
        {
            //Apriamo un nuovo Form per modificare l'elemento selezionato
            ModifyDatabase modify = new ModifyDatabase(cbTable.Text, GetNameAndTypeColum(dataGridElement), valConst.updateDB, CONSTANTS.stringConnection, dataGridElement.SelectedRows[0].Cells[0].Value.ToString());
            //modify.FirstValueReadOnly = true;
            modify.ShowDialog();
        }

        /// <summary>
        /// Eliminiamo un elemento dal nostro database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(valConst.deleteQuestionMSG, valConst.sureQuestionMSG, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string query = valConst.deleteDB + cbTable.Text + valConst.whereDB + dataGridElement.Columns[0].Name + " ='" + dataGridElement.SelectedRows[0].Cells[0].Value.ToString() + "';";
                queryDB.InsertElement(CONSTANTS.stringConnection, query);
            }
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
            BindingSource source = new BindingSource { DataSource = table };
            dataGrid.DataSource = source;
        }

        /// <summary>
        /// Settiamo il tipo di elemento City / Country e visualizziamo l'elemento
        /// </summary>
        /// <param name="ShowMex">Devidiamo se visualizzare o no la MessageBox con l'elemento</param>
        public void SetElement(bool ShowMex)
        {
            // if (cbTable.Text.CompareTo("city") == 0) //city
            {
                try
                {
                    City cityObj = new City();
                    DataRow row = (dataGridElement.SelectedRows[0].DataBoundItem as DataRowView).Row;
                    cityObj = (City)row;
                    if (ShowMex)
                    {
                        MessageBox.Show(cityObj.CityName + " : " + cityObj.ReferenceContry + " - " + cityObj.Country.CountryName, valConst.titleReferenceMSG);
                    }
                    return; //l'elemento selezionato è una città, concludiamo l'evento
                }
                catch (Exception)
                { }
            }

            // if (cbTable.Text.CompareTo("country") == 0) //contry
            {
                try
                {
                    Country contryObj = new Country();
                    DataRow row = (dataGridElement.SelectedRows[0].DataBoundItem as DataRowView).Row;
                    contryObj = (Country)row;
                    if (ShowMex)
                    {
                        MessageBox.Show(contryObj.Capital + " : " + contryObj.CountryName, valConst.titleReferenceMSG);
                    }
                    return;//l'elemento selezionato è uno stato, chiudiamo l'evento
                }
                catch (Exception)
                { }
            }
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
                if (dataGrid.Columns[i].Name.CompareTo("ID") != 0)
                {
                    //Otteniamo il nome della colonna ed il valore del tipo di elemento 
                    st.Append(dataGrid.Columns[i].Name /*+" " + dataGrid.Columns[i].ValueType.ToString().Replace("System", "")*/);

                    if (i < dataGrid.Columns.Count - 1)
                    {
                        st.Append(",");
                    }
                }
                else
                {
                    //Non inseriamo la colonna ID
                }
            }
            //MessageBox.Show(st.ToString());
            return st.ToString();
        }

        /// <summary>
        /// Visualizziamo una specifica colonna della tabella di un database
        /// </summary>
        public void ShowTable()
        {
            MySqlConnection sqlConnection = new MySqlConnection(CONSTANTS.stringConnection);
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
        public void VerifyConnectionDatabase()
        {

            //connectionString ="Server=____________;Port=__________;Database=_______;Uid=____________;password=______;"

            try
            {
                // Alternativa, separando le attività:
                /*
                sqlConnect = new MySqlConnection();
                sqlConnect.ConnectionString = stringConnection;
                */
                MySqlConnection sqlConnection = new MySqlConnection(CONSTANTS.stringConnection);
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
