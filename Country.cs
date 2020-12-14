using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL30
{
    /*
    CREATE TABLE "Country" ("id"	INTEGER NOT NULL,
"name"	TEXT NOT NULL ,
"size_km"	INT NOT NULL ,
"bith_year"	INT NOT NULL,
"CapitalCity_id"	INT,
FOREIGN KEY(CapitalCity_id) REFERENCES CapitalCity(id),
PRIMARY KEY("ID"))
*/
    class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Size_km { get; set; }
        public int Bith_year { get; set; }
        public int CapitalCity_id { get; set; }

        public override string ToString()
        {
            return base.ToString() + JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public Country()
        {

        }

        public static bool operator ==(Country country1, Country country2)
        {
            return country1.Id == country2.Id;
        }

        public static bool operator !=(Country country1, Country country2)
        {
            return !(country1 == country2);
        }

        public override bool Equals(object obj)
        {
            Country country = obj as Country;
            if (country != null)
                return this.Id == country.Id;

            return false;
        }

        public override int GetHashCode()
        {
            return this.Id;
        }

    }
}
