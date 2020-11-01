using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MariaDB
{
    /// <summary>
    /// Struttura oggetto City 
    /// </summary>
    public class City
    {
        int cityID;
        string cityName;
        int referenceContry;
        Country country = new Country();



        public int CityID { get => cityID; set => cityID = value; }
        public string CityName { get => cityName; set => cityName = value; }
        public int ReferenceContry { get => referenceContry; set => referenceContry = value; }
        public Country Country { get => country; set => country = value; }

        public static explicit operator City(DataRow dr)
        {
            City cityObj = new City();     

            cityObj.CityID = Int32.Parse(dr.ItemArray[0].ToString());
            cityObj.CityName = dr.ItemArray[1].ToString();
            cityObj.ReferenceContry = Int32.Parse(dr.ItemArray[2].ToString());

            cityObj.SetCountry(cityObj);

            return cityObj;
        }

        public void SetCountry(City cityObj)
        {
            ValueConstant valConst = new ValueConstant();
            QueryDatabase queryDB = new QueryDatabase();

            string stringConnection = "server=" + valConst.nameServer + ";port=" + valConst.port + ";Database=" + valConst.databaseName + ";uid=" + valConst.nameUser + ";password=" + valConst.password;

            string query = valConst.findRefCountry + cityObj.ReferenceContry;

            cityObj.Country = queryDB.ReturnCountry(stringConnection, query);
        }

       
    }

    /// <summary>
    /// Struttura oggetto Country
    /// </summary>
    public class Country
    {
        int contryID;
        string countryName;
        string countryAbbr;
        string capital;

        public int ContryID { get => contryID; set => contryID = value; }
        public string CountryName { get => countryName; set => countryName = value; }
        public string CountryAbbr { get => countryAbbr; set => countryAbbr = value; }
        public string Capital { get => capital; set => capital = value; }


        public static explicit operator Country(DataRow dr)
        {
            Country countryObj = new Country();

            countryObj.ContryID = Int32.Parse(dr.ItemArray[0].ToString());
            countryObj.CountryName = dr.ItemArray[1].ToString();
            countryObj.CountryAbbr = dr.ItemArray[2].ToString();
            countryObj.Capital =  dr.ItemArray[3].ToString();

            return countryObj;
        }
    }
}
