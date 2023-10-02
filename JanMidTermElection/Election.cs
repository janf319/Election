using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanMidTermElection
{
    internal class Election
    {
        private string[] candidatesNames = new string[NUMOFCANDIDATES];
        private const int NUMOFCANDIDATES = 5;
        private int[] votes = new int[5];

        public int NumOFCANDIDATES 
        {
            get { return NUMOFCANDIDATES; }
        }

        public Election()
        {
        }
        public string FindWinner() 
        {//a temporary int to hold the index of largest value in votes array
            int temporary = 0 ;
            for(int i = 0; i < votes.Length; i++) 
            {
                if (votes[i] > votes[temporary])
                {
                    temporary = i;
                }
            }//returning the name that corresponds to the votes array 
            return candidatesNames[temporary]; 
        }

        //method to display the the contents of array that user has entered 
        public string GetCandidateName(int index) 
        {
            return candidatesNames[index];
        }
        public int GetCandidateVotes(int index) 
        {
            return votes[index];
        }

        //filling the parallel array through user's input 
        public void SetCandidateName(string name, int index) 
        {
            candidatesNames[index] = name;
        }
        public void SetVote(int cvotes, int index)
        {
            votes[index] = cvotes;
        }

        //method to add the content inside an array
        public int TotalVotes() 
        {
            int totalVotes = 0;
            for(int i = 0;i < votes.Length; i++) 
            {
                totalVotes += votes[i];
            }
            return totalVotes;
        }
    }
}
