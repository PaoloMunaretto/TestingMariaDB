using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariaDB
{
    public class ValueConstant
    {
        //*******************************************************************************
        //    Versioning for this software

        public string versionSW = " 1.0.0";

        //*******************************************************************************
        //    Connection MySql.Data.MySqlClient

        public string nameServer = "127.0.0.1"; //localHost
        public string nameUser = "localhost";
        public string password = String.Empty; //Per il mio database, non ho selezionato alcuna password
        public int port = 3306;


        //*******************************************************************************
        //    list of Database in localHost

        public string databaseName = "employees";


        //*******************************************************************************
        //    Array of tables

        public string[] arrTable = new string[10];// { "person", "person2", "person3", "person4", "city", "country", "employeesname" };       
        
        public void SetTablesArray(string tables)
        {
            arrTable = tables.Split(',');
        }

        //*******************************************************************************
        //   Query connection for Database MariaDB

        public string readAllTableDB = "SHOW TABLES";
        public string readTableDB = "SELECT * FROM ";
        public string findRefCountryDB = "SELECT * FROM country WHERE contryID=";
        public string orderDescDB = "SELECT {0}.* FROM {0} ORDER BY {1} DESC";
        public string valuesDB = " VALUES ";
        public string insertDB = "INSERT INTO ";
        public string updateDB = "UPDATE ";
        public string setDB = " SET ";
        public string whereDB = " WHERE ";
        public string deleteDB = "DELETE FROM ";

        //*******************************************************************************
        //    MessageBox text and information

        public string connectionOkMSG = "Connection open";
        public string titleReferenceMSG = "Reference Object";
        public string errorMSG = "ERROR EXCEPTION";
        public string modifyDBCompetMSG = "Query for database completed!";

        //    MessageBox Questions information
        public string deleteQuestionMSG = "DELETE ELEMENT?";
        public string sureQuestionMSG = "ARE YOU SHURE?";
        public string saveQuestionMSG = "SAVE INFORMATION?";

    }
}
