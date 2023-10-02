using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanMidTermElection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Info info = new Info();
            ElectionUI ui = new ElectionUI();

            info.DisplayInfo();
            ui.MainMethod();
            Console.ReadKey();
        }
    }
}
