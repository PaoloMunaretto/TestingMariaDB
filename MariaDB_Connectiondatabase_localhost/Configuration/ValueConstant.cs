using System;

namespace MariaDB
{
    public class ValueConstant
    {
        //*******************************************************************************
        //    Array of tables

        public string[] arrTable = new string[100];// { "person", "person2", "person3", "person4", "city", "country", "employeesname" };       

        public void SetTablesArray(string tables)
        {
            arrTable = tables.Split(',');
        }

        //*******************************************************************************
        //   Query connection for Database MariaDB

        public string readAllTableDB = "SHOW TABLES";
        public string readTableDB = "SELECT * FROM ";
        public string findRefCountryDB = "SELECT * FROM country WHERE ID=";
        public string orderDescDB = "SELECT {0}.* FROM {0} ORDER BY {1} DESC";
        public string valuesDB = " VALUES ";
        public string insertDB = "INSERT INTO ";
        public string updateDB = "UPDATE ";
        public string setDB = " SET ";
        public string whereDB = " WHERE ";
        public string IdDB = "ID";
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

    public static class CONSTANTS
    {
        //*******************************************************************************
        //    Connection string for connecting with database 
        public static string stringConnection = ""; //Viene inizializzata all'avvio del Form dedicato


        //*******************************************************************************
        //    Versioning for this software
        public const string VERSION_SW = "1.0.0";
        //  public static string VERSION_SW = "1.0.0";  //potrei indicare la variabile come statica, ma non visualizzerebbe il valore col puntatore
        

        //*******************************************************************************
        //    Connection MySql.Data.MySqlClient
        public const string NAME_SERVER = "127.0.0.1"; //localHost
        public const string NAME_USER = "localhost";
        public static string PASSWORD = String.Empty; //Per il mio database, non ho selezionato alcuna password, ma la variabile la rendiamo statica
        public const int PORT = 3306;


        //*******************************************************************************
        //    list of Database in localHost

        public const string DATABASE_NAME = "employees";


    }
}
