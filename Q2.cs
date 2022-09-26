using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sept26_Assignment
{
    internal class Q2
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Student =
                     new Dictionary<int, string>();
            Student.Add(39582, "Charitha");
            Student.Add(28462, "Lakshmi");
            Student.Add(38498, "Sai");

            foreach (KeyValuePair<int, string> ele in Student)
            {
                Console.WriteLine("{0} - {1}",
                          ele.Key, ele.Value);

            }


        }

    }
}
