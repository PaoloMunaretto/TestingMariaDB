﻿using System;
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
               
        string stringConnection = "";
        string tableName; //Nome della tabella dove effettuare le modifiche
        string query;  //stringa query per la connessine
        string valueElement;
        string setElement;


        int idUpdate;
        bool firstValueReadOnly = false;

        public bool FirstValueReadOnly { get => firstValueReadOnly; set => firstValueReadOnly = value; }
        public int IdUpdate { get => idUpdate; set => idUpdate = value; }

        public ModifyDatabase(string tableName_, string header, string labelHeaderQuery, string connection)
        {
            tableName = tableName_; //Settiamo il nome della tabella
            stringConnection = connection; //Settiamo la stringa di connessione

            valueElement = valCost.values; //Elementi per query
            setElement = valCost.set;

            InitializeComponent();
            dtg.SetUpDataGridViewHeaderString(dataGridTable, header);
            dtg.SetupDataGridViewHeaderColor(dataGridTable);

            this.InformationtoolStripLabel.Text = labelHeaderQuery +tableName_; //Visualizziamo l'inizio della query
            query = labelHeaderQuery + tableName_;

            //Vediamo se rendere la prima colonna di sola lettura (serve per la query UPDATE)
            if (firstValueReadOnly)
            {
                dataGridTable.Columns[0].ReadOnly = firstValueReadOnly;
            }
        }


        private void SavetoolStripButton_Click(object sender, EventArgs e)
        {
            //Salviamo il nostro elemento
            DialogResult res = MessageBox.Show(valCost.save, valCost.saveinfo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (res == DialogResult.Yes && InformationtoolStripLabel.Text.Contains(valCost.insert))
            {
                InsertInto(); //Inseriamone uno nuovo
            }

            if (res == DialogResult.Yes && InformationtoolStripLabel.Text.Contains(valCost.update))
            {
                UpdateTable(); //Modifichiamolo secondo il valore "ID"
            }
        }

        /// <summary>
        /// Inseriamo il nuovo elemento sul nostro database
        /// </summary>
        public void InsertInto()
        {
            //Componiamo la nostra query secondo nomi delle colonne e gli elementi delle celle
            for (int i = 0; i < dataGridTable.Columns.Count; i++)
            {
                if (i == 0)
                {
                    query += " (";
                    valueElement += " ('";
                }

                query += dataGridTable.Columns[i].Name.ToString();

                if (dataGridTable.Rows[0].Cells[i].Value != null)
                {
                    valueElement += dataGridTable.Rows[0].Cells[i].Value.ToString();
                }

                else
                {
                    valueElement += "";
                }

                if (i < dataGridTable.Columns.Count - 1)
                {
                    query += ",";
                    valueElement += "','";
                }

                if (i == dataGridTable.Columns.Count - 1)
                {
                    query += ")";
                    valueElement += "');";
                }
            }
            query += valueElement;
            //Metodo funziona, ma i valori inseriti devono essere corretti tra a priori
            qdb.InsertElement(stringConnection, query);

            this.Close();
        }

        /// <summary>
        /// Modifichiamo l'elemento nel nostro database
        /// </summary>
        public void UpdateTable()
        {
            string whereElement = valCost.where;

            //Componiamo la nostra query secondo nomi delle colonne e gli elementi delle celle
            for (int i = 0; i < dataGridTable.Columns.Count; i++)
            {
                if (i == 0)
                {
                    query += valCost.set;
                                       
                    whereElement += dataGridTable.Columns[i].Name.ToString() + "=";
                    whereElement += "'" + dataGridTable.Rows[0].Cells[i].Value.ToString() + "';";                    
                }

                query += dataGridTable.Columns[i].Name.ToString();
               

                if (dataGridTable.Rows[0].Cells[i].Value != null)
                {
                    query += "='"+dataGridTable.Rows[0].Cells[i].Value.ToString();                   
                }

                if (i == dataGridTable.Columns.Count - 1)
                {
                    query += "'";
                }
                else
                { 
                    query += "',"; 
                }
                
            }
            query +=  whereElement;
            //Metodo funziona, ma i valori inseriti devono essere corretti tra loro
            qdb.InsertElement(stringConnection, query);

            this.Close();
        }
    }
}
