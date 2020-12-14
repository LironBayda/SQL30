using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL30
{
    class Program
    {
        static void Main(string[] args)
        {

            DAO dAO = new DAO();
            dAO.GetCountyAndItsCapitalCityName(0);
            dAO.GetCountyAndItsCapitalCityDDetails(1);
            dAO.GetCountyAndItsCapitalCityName("a");
            dAO.GetCountyAndItsCapitalCityDDetails("c");
            dAO.GetCountyAndItsCapitalCityName('i');

            Console.ReadLine();

        }
    }
}
