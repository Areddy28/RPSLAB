using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLAB
{
    class UserPlayer : Player
    {
        public UserPlayer() 
        {
            Console.WriteLine("What is your name?");
            Name = Console.ReadLine(); 
        }

        //We want our user to select R P or S
        //and if we get anything else, ask for an RPS value again
        public override RPSnum GenerateRPS()
        {
            Console.WriteLine("Please select rock paper or scissors (Or r p or s for short");
            string answer = Console.ReadLine(); 

            switch(answer)
            {
                case "rock":
                    return RPSnum.Rock;
                case "r":
                    return RPSnum.Rock;
                case "paper":
                    return RPSnum.Paper;
                case "p":
                    return RPSnum.Paper;
                case "scissors":
                    return RPSnum.Scissors;
                case "s":
                    return RPSnum.Scissors;
                default:
                    Console.WriteLine("I'm sorry");
                    return GenerateRPS();

            }
        }
    }
}
