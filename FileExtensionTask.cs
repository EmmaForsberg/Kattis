using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kattis
{
    internal class FileExtensionTask
    {
        public void ReadFileName()
        {
            Console.WriteLine("Enter filename");
            var filename = Console.ReadLine();


            bool isValid = Regex.IsMatch(filename, @"^[a-zA-Z0-9.]");
            if (isValid)
            {
                var indexof = filename.LastIndexOf('.');
                var lengthofword = filename.Length;
                var totallength = lengthofword - indexof;

                var result = filename.Substring(indexof, totallength);

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
