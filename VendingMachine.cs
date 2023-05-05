using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacheSerise
{
    public class VendingMachine
    {
        public void CountNote()
        {
            Console.Write("Enter the amount of change to be returned: ");
            int change = int.Parse(Console.ReadLine());

            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] count = new int[8];

            CalculateNotes(change, notes, count);

            int totalNotes = 0;

            Console.WriteLine("Notes to be returned:");

            for (int i = 0; i < 8; i++)
            {
                if (count[i] != 0)
                {
                    Console.WriteLine(notes[i] + " Rs Note : " + count[i]);
                    totalNotes += count[i];
                }
            }

            Console.WriteLine("Minimum number of notes needed: " + totalNotes);
        }

        static void CalculateNotes(int change, int[] notes, int[] count)
        {
            if (change == 0)
            {
                return;
            }

            for (int i = 0; i < 8; i++)
            {
                if (change >= notes[i])
                {
                    count[i] = change / notes[i];
                    change = change % notes[i];
                    break;
                }
            }

            CalculateNotes(change, notes, count);
        }

    }
}

