using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariaDB
{
    public class ValueConstant
    {   //*******************************************************************************
        //    Connection MySql.Data.MySqlClient

        public string nameServer = "127.0.0.1"; //localHost
        public string nameUser = "localhost";
        public string password = String.Empty; //Per il mio database, non ho selezionato alcuna password
        public int port = 3306;

        public string databaseName = "employees";


        //*******************************************************************************
        //    Array of tables

        public string[] arrTable = new string[10];// { "person", "person2", "person3", "person4", "city", "country", "employeesname" };
       
        
        public void SetTablesArray(string tables)
        {
            arrTable = tables.Split(',');
        }

        //*******************************************************************************
        //   Query connection for Database

        public string readAllTable = "SHOW TABLES";
        public string readTable = "SELECT * FROM ";
        public string findRefCountry = "SELECT * FROM country WHERE contryID=";


        //*******************************************************************************
        //    MessageBox text and information

        public string connectionOk = "Connection open";
        public string titleReference = "Reference Object";

    }
}
