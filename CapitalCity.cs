using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL30
{

    /*
     * CREATE TABLE "CapitalCity" ("id"	INTEGER NOT NULL,
"name"	TEXT NOT NULL ,
"NumCitizens"	INT NOT NULL ,
"Country_id"	INT,
FOREIGN KEY (Country_id) REFERENCES Country(id),
PRIMARY KEY("ID"))
*/
    class CapitalCity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumCitizens { get; set; }
        public int Country_id { get; set; }

        public override string ToString()
        {
            return base.ToString() + JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public CapitalCity()
        {

        }

        public static bool operator ==(CapitalCity capitalCity1, CapitalCity capitalCity2)
        {
            return capitalCity1.Id == capitalCity2.Id;
        }

        public static bool operator !=(CapitalCity capitalCity1, CapitalCity capitalCity2)
        {
            return !(capitalCity1 == capitalCity2);
        }

        public override bool Equals(object obj)
        {
            CapitalCity capitalCity = obj as CapitalCity;
            if (capitalCity != null)
                return this.Id == capitalCity.Id;

            return false;
        }

        public override int GetHashCode()
        {
            return this.Id;
        }

    }
}

