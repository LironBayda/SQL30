using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL30
{
    class DAO: IDAO
    {
        SqliteConnection connection;

        public DAO()
        {
            connection = new SqliteConnection($"Data Source = C:\\Users\\liron\\Downloads\\SQL30.db");

        }
        /*       CREATE TABLE "CUSTOMER" (
       "ID"	INTEGER NOT NULL,
       "FRIST_NAME"	TEXT NOT NULL ,
       "LAST_NAME"	TEXT NOT NULL ,
       "AGE"	INT NOT NULL,
       "ADDRESS_CITY"	CHAR(50),
       "ADDRESS_STREET"	CHAR(50),
       "PH_NUMBER" CHAR(50) UNIQUE,
       PRIMARY KEY("ID"))*/

        public object GetCountyAndItsCapitalCityName(int countyId)
        {
            // creating conenction to the Sqlite database

            connection.Open(); 
            using (SqliteCommand cmd = new SqliteCommand("SELECT  Country.id AS country_id, Country.name AS country_name ,CapitalCity.id AS capitalCity_id ,CapitalCity.name AS capitalCity_name FROM  Country  JOIN  CapitalCity   ON Country.CapitalCity_id = CapitalCity.id", connection))
            {

                using (SqliteDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read() == true)
                    {
                        var result = new
                        {
                            Id = Convert.ToInt32(reader["country_id"]),
                            countryName = (string)reader["country_name"],
                            capitalCityName = (string)reader["capitalCity_name"],
                        };


                        if (result.Id == countyId)
                        {
                            Console.WriteLine(result.capitalCityName+" "+result.countryName+ " " + result.Id);     

                            return result;

                        }

                    }

                }
            }

            connection.Close();

            return null;

        }

        public object GetCountyAndItsCapitalCityDDetails(int countyId)
        {
            // creating conenction to the Sqlite database

            connection.Open();
            using (SqliteCommand cmd = new SqliteCommand("SELECT  Country.id AS country_id, Country.name AS country_name ,CapitalCity.id AS capitalCity_id ,CapitalCity.name " +
                "AS capitalCity_name,CapitalCity.NumCitizens FROM  Country  JOIN  CapitalCity   ON Country.CapitalCity_id = CapitalCity.id", connection))
            {

                using (SqliteDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read() == true)
                    {
                        var result = new
                        {
                            Id = Convert.ToInt32(reader["country_id"]),
                            countryName = (string)reader["country_name"],
                            capitalCityName = (string)reader["capitalCity_name"],
                            numCitizens= Convert.ToInt32(reader["NumCitizens"]),
                        };

                        if (result.Id == countyId)
                        {
                            Console.WriteLine(result.capitalCityName + " " + result.countryName + " " + result.Id + " " + result.numCitizens);

                            return result;

                        }

                    }

                }
            }

            connection.Close();

            return null;

        }

        public object GetCountyAndItsCapitalCityName(string countyName)
        {
            // creating conenction to the Sqlite database

            connection.Open();
            using (SqliteCommand cmd = new SqliteCommand("SELECT  Country.id AS country_id, Country.name AS country_name ,CapitalCity.id AS capitalCity_id ,CapitalCity.name AS capitalCity_name FROM  Country  JOIN  CapitalCity   ON Country.CapitalCity_id = CapitalCity.id", connection))
            {

                using (SqliteDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read() == true)
                    {
                        var result = new
                        {
                            Id = Convert.ToInt32(reader["country_id"]),
                            countryName = (string)reader["country_name"],
                            capitalCityName = (string)reader["capitalCity_name"],
                        };


                        if (result.countryName == countyName)
                        {
                            Console.WriteLine(result.capitalCityName + " " + result.countryName + " " + result.Id);

                            return result;

                        }

                    }

                }
            }

            connection.Close();

            return null;

        }

       public object GetCountyAndItsCapitalCityDDetails(string countyName)
        {
            // creating conenction to the Sqlite database

            connection.Open();
            using (SqliteCommand cmd = new SqliteCommand("SELECT  Country.id AS country_id, Country.name AS country_name ,CapitalCity.id AS capitalCity_id ,CapitalCity.name " +
                "AS capitalCity_name,CapitalCity.NumCitizens FROM  Country  JOIN  CapitalCity   ON Country.CapitalCity_id = CapitalCity.id", connection))
            {

                using (SqliteDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read() == true)
                    {
                        var result = new
                        {
                            Id = Convert.ToInt32(reader["country_id"]),
                            countryName = (string)reader["country_name"],
                            capitalCityName = (string)reader["capitalCity_name"],
                            numCitizens = Convert.ToInt32(reader["NumCitizens"]),
                        };


                        if (result.countryName == countyName)
                        {
                            Console.WriteLine(result.capitalCityName + " " + result.countryName + " " + result.Id + " " + result.numCitizens);

                            return result;

                        }

                    }

                }
            }

            connection.Close();

            return null;

        }

        public object GetCountyAndItsCapitalCityName(char countyNameFristLetter)
        {
            // creating conenction to the Sqlite database

            connection.Open();
            using (SqliteCommand cmd = new SqliteCommand("SELECT  Country.id AS country_id, Country.name AS country_name ,CapitalCity.id AS capitalCity_id ,CapitalCity.name AS capitalCity_name FROM  Country  JOIN  CapitalCity   ON Country.CapitalCity_id = CapitalCity.id", connection))
            {

                using (SqliteDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read() == true)
                    {
                        var result = new
                        {
                            Id = Convert.ToInt32(reader["country_id"]),
                            countryName = (string)reader["country_name"],
                            capitalCityName = (string)reader["capitalCity_name"],
                        };


                        if (result.countryName[0] == countyNameFristLetter)
                        {
                            Console.WriteLine(result.capitalCityName + " " + result.countryName + " " + result.Id);

                            return result;

                        }

                    }

                }
            }

            connection.Close();

            return null;

        }

    }
}
