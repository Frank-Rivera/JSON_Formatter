using JSON_Formatter.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Formatter.Library.Factories
{
    public class PrettyJSONFormatterFactory
    {

        public static IPrettyJSONFormatter Get(string rawJSON) {
            return new PrettyJSONFormatter(rawJSON);
        }

    }
}
