﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace JanMidTermElection
{
    internal class Info
    {
        public void DisplayInfo()
        {
            const string barrior = "************************************************";
            WriteLine(barrior);
            WriteLine();
            WriteLine("Name:\t\tFatima Jan");
            WriteLine("Course:\t\tITDEV-115-200");
            WriteLine("Intructor:\tJanese Christie");
            WriteLine("MidTerm:\tElection Program App");
            WriteLine("Date:\t\t" + DateTime.Today.ToShortDateString());
            WriteLine();
            WriteLine(barrior);
        }
    }
}
