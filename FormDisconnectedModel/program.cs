using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pracDisconnected
{
     class program
    {

        public static void Main (string[] args)
        {
            Console.WriteLine("Adding a record...");
            Application.Run(new AddRecord());//to run the form

            Console.WriteLine("Successfull");
        }
    }
}
