using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace JanMidTermElection
{
    internal class ElectionUI
    {
        private int candidates = 5;
        private Election theElection = new Election();

        public ElectionUI()
        {
            //empty constructor made as per UML
            // could put MainMethod() here
        }
        public void DisplayResults()
        {
            Clear();
            WriteLine("\tNames \t\tVotes \tPercentage");
            for(int i = 0; i < candidates; i++) 
            {
                WriteLine("\t{0}\t{1}\t{2:N2}%", theElection.GetCandidateName(i), theElection.GetCandidateVotes(i),
                         ((double) theElection.GetCandidateVotes(i) / (double) theElection.TotalVotes()) * 100);
            }//method returning value int declared double by putting it directly into paranthesis
            //UML should have had a calculate percentage method
            //Dividing two doubles and multiplying with 100 to get percentage as last argument

            WriteLine("\nThe Winner is:  {0}", theElection.FindWinner());
        }

        public void PromptforInt(int candidate) 
        {//validating user's input to be int.
            string inValue;
            int votes;                   //0 argument can also be GetCandidateName
            Write("Please enter candidate {0} votes:\t", candidate + 1);
            inValue = ReadLine();
            while (int.TryParse(inValue, out votes) == false)
            {
                WriteLine("Error. \nPlease enter a numerical value for number of votes");
                Write("Please enter candidate {0}'s vote count: ", theElection.GetCandidateName(candidate));
                inValue = ReadLine();
            }
            //Passing user's input to the method that will make the two Arrays parralell
            theElection.SetVote(votes, candidate);
        }

        public void PromptforString(int candidate) 
        {
            Write("\nPlease Enter candidate {0} name:\t", (candidate + 1));
            //passing user's input in the paranthesis directly to fill the Array
            //Can also assign string variable to user input and pass that string variable to fill array
            theElection.SetCandidateName(ReadLine(), candidate);
        }

        public void MainMethod()
        {//a for loop to fill the array using candidates as a controlled variable
            for (int i = 0; i < candidates; i++)
            {
                PromptforString(i);
                PromptforInt(i);
            }
            DisplayResults();
        }
    }
}
