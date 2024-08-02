using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Determinator
{


    internal class Program
    {

        static void Main(string[] args)
        {
        
            int likeInput;
            int fairInput;
            int kindInput;
            int funInput;
            int truthInput;
            Console.WriteLine("Coastal's Admin Selector");
            Console.WriteLine("Please Continue with Player's Name.\n");
            string candidateName = Console.ReadLine();
            Console.WriteLine("\n" + candidateName + " is this okay?\n Press Enter to Confirm...");
            Console.ReadLine();
            Console.WriteLine("\nPlease enter the candidates score on the following features between 1-10.");
            Console.WriteLine ("\nLikeability:");
            string candidateLikeable = Console.ReadLine();

            if (Int32.TryParse(candidateLikeable, out likeInput))
            {
                Console.WriteLine("Likeability Rating Successful: " + likeInput);
                Console.WriteLine("\nPress Enter/Return to continue....");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Rating Failed.");
                Console.WriteLine("\nTry again using only a number between 1 and 10.");
                candidateLikeable = Console.ReadLine();
            }

            Console.WriteLine("Fairness:");
            string candidateFair = Console.ReadLine();

            if (Int32.TryParse(candidateFair, out fairInput))
            {
                Console.WriteLine("Fairness Rating Successful: " + fairInput);
                Console.WriteLine("\nPress Enter/Return to continue....");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Rating Failed.");
                Console.WriteLine("\nTry again using only a number between 1 and 10.");
                candidateFair= Console.ReadLine();
            }

            Console.WriteLine("Kindness:");
            string candidateKind = Console.ReadLine();

            if (Int32.TryParse(candidateKind, out kindInput))
            {
                Console.WriteLine("Kindness Rating Successful: " + kindInput);
                Console.WriteLine("\nPress Enter/Return to continue....");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Rating Failed.");
                Console.WriteLine("\nTry again using only a number between 1 and 10.");
                candidateKind = Console.ReadLine();
            }
            Console.WriteLine("Fun :");
            string candidateFun = Console.ReadLine();

            if (Int32.TryParse(candidateFun, out funInput))
            {
                Console.WriteLine("Fun Rating Successful: " + funInput);
                Console.WriteLine("\nPress Enter/Return to continue....");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Rating Failed.");
                Console.WriteLine("\nTry again using only a number between 1 and 10.");
                candidateFair = Console.ReadLine();
            }
            Console.WriteLine("Honesty:");
            string candidateTruth = Console.ReadLine();

            if (Int32.TryParse(candidateTruth, out truthInput))
            {
                Console.WriteLine("Honesty Rating Successful: " + truthInput);
                Console.WriteLine("\nPress Enter/Return to continue....");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Rating Failed.");
                Console.WriteLine("\nTry again using only a number between 1 and 10.");
                candidateTruth = Console.ReadLine();
            }

            double candidateAvg = (likeInput + truthInput + funInput + kindInput + fairInput) / 5 * 10;

            Console.WriteLine("\n" + candidateName + " is a " + candidateAvg + "% match for admin consideration!");
            Console.WriteLine("\nPress Enter/Return to continue....");
            Console.ReadLine();

        }

      
    }
}
