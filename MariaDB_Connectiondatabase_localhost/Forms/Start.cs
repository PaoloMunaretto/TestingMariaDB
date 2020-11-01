﻿using System;
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
        DataGridViewConfiguration dataGridConfig = new DataGridViewConfiguration();
        ValueConstant valConst = new ValueConstant();
        QueryDatabase queryDB = new QueryDatabase();

        public string stringConnection = ""; //Connettersi al database


        public Start()
        {
            InitializeComponent();
            stringConnection = "server=" + valConst.nameServer + ";port=" + valConst.port + ";Database=" + valConst.databaseName + ";uid=" + valConst.nameUser + ";password=" + valConst.password;

            dataGridElement.AllowUserToAddRows = false;

            valConst.SetTablesArray(queryDB.ReadAllTablesMariaDB(stringConnection, valConst.readAllTable));

            foreach (string item in valConst.arrTable)
            {
                if (item.Length > 2)
                    cbTable.Items.Add(item);
            }
        }

        /// <summary>
        /// Visualizziamo tutti gli elementi della tabella
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Connection_Click(object sender, EventArgs e)
        {
            string query = valConst.readTable + cbTable.Text;

            DataTable table = queryDB.RowsInTableMariaDB(stringConnection, query);

            SetTableInDataGrid(dataGridElement, table);
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
                    MessageBox.Show(cityObj.CityName + " : " + cityObj.ReferenceContry + " - " + cityObj.Country.CountryName, valConst.titleReference);
                    return; //l'elemento selezionato è una città, concludiamo l'evento
                }
                catch (Exception ex)
                { }
            }

            // if (cbTable.Text.CompareTo("country") == 0) //contry
            {
                try
                {
                    Country contryObj = new Country();
                    DataRow row = (dataGridElement.SelectedRows[0].DataBoundItem as DataRowView).Row;
                    contryObj = (Country)row;
                    MessageBox.Show(contryObj.Capital + " : " + contryObj.CountryName, valConst.titleReference);
                    return;//l'elemento selezionato è uno stato, chiudiamo l'evento
                }
                catch (Exception ex)
                { }
            }
        }













        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------  Metods not used, only for Testing
        //-----------------------------------------------------------------------------------------------------

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
                    MessageBox.Show(valConst.connectionOk);
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
