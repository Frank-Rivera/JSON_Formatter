using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Formatter.Test
{
    class Program
    {
        static void Main(string[] args)
        {

            var sample = "{ \"_id\" : { \"$oid\" : \"50906d7fa3c412bb040eb577\" }, \"student_id\" : 0, \"type\" : \"exam\", \"score\" : 54.6535436362647 }";

            var sample2 = "{ \"_id\" : 0, \"name\" : \"aimee Zank\", \"scores\" : [ { \"type\" : \"exam\", \"score\" : 1.463179736705023 }, { \"type\" : \"quiz\", \"score\" : 11.78273309957772 }, { \"type\" : \"homework\", \"score\" : 6.676176060654615 }, { \"type\" : \"homework\", \"score\" : 35.8740349954354 } ] }";

            var formatter = Library.Factories.PrettyJSONFormatterFactory.Get(sample2);

            System.Console.Write(formatter.GetFormattedString());

            System.Console.Read();

        }
    }
}
