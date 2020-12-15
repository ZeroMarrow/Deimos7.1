using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deimos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string i = new string(new char[] { '2', 'a', 'g', '8', 's', 'h', '4', '0', 'j', '1' });
                Console.WriteLine(i.Replace("2", " ").Replace("2", " ").Replace ("a", " ").Replace ("8", " ").Replace ("s", " ").Replace ("0", " "));
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}