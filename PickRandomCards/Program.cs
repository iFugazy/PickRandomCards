using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many cards would you like to pick? ");

            string line = Console.ReadLine();
            //nuumber of cards variable is taking from the user input variable called line.
            //int.TryParse changes the outputted string datatype into an int datatype
            if (int.TryParse(line, out int numberOfCards))
            {
                //CardPicker class calls the pickSomeCards method to randomly choose cards
                CardPicker.PickSomeCards(numberOfCards);
                
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    //Prints the amount of cards the user desired via numberOfCards variable.
                    Console.WriteLine(card);
                }                           

            }
            else
            { 
                //If user inputs an invalid number
                Console.WriteLine("Please enter a valid number!"); 
            }
            //Pauses program and allows user to read Console.
            Console.ReadLine();
        }
    }
}
