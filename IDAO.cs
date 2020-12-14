using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL30
{
    interface IDAO
    {
         object GetCountyAndItsCapitalCityName(int countyId);



         object GetCountyAndItsCapitalCityDDetails(int countyId);


         object GetCountyAndItsCapitalCityName(string countyName);



         object GetCountyAndItsCapitalCityDDetails(string countyName);



         object GetCountyAndItsCapitalCityName(char countyNameFristLetter);


    }
}
