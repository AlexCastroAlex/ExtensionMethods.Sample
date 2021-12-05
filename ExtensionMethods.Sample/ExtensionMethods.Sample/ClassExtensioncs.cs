using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Sample
{
    public static class ClassExtensioncs
    {
        public static string SayMyName(this Person p)
        {
            return  $"My name is: {p.FirstName} {p.LastName}";
        }

        public static string SayMyName(this PersonRecord p)
        {
            return $"My name is: {p.FirstName} {p.LastName}";
        }
    }
}
