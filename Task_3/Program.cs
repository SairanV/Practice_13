using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileMode mode = FileMode.Open;
            mode |= FileMode.Create;
            mode |= FileMode.Truncate;

            ///ERROR 404
        }
    }
}
