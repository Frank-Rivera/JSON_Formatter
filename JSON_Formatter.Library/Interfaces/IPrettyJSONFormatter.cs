using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Formatter.Library.Interfaces
{
    public interface IPrettyJSONFormatter
    {

        string RawString { get; set; }

        string GetFormattedString();

    }
}
