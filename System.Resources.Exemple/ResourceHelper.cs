using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Resources.Exemple
{
    public class ResourceHelper    {

        public static string getResource(string key){

            System.Resources.ResourceManager rm = System.Resources.ResourceManager(typeof(System.Resources.Example.Main));
            return rm.GetString(key);
        }

    }
}