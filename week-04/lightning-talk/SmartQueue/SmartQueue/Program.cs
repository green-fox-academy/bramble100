using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;

namespace SmartQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            // only Chuck
            SmartQueue smartQueue = new SmartQueue();
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            Presenter.PrintStatusForQueue(smartQueue, "SmartQueue for Chuck created");

            Console.WriteLine($" {smartQueue.ToString()}");

            Console.WriteLine();
            
            // only Dutch and Chuck of course
            SmartQueue smartQueueForDutch = new SmartQueue(Country.Dutch);
            smartQueueForDutch.Enqueue(); // "Chuck Norris"
            smartQueueForDutch.Enqueue("William-Alexander");
            smartQueueForDutch.Enqueue("Juliana");

            Console.WriteLine($" {smartQueueForDutch.ToString()}");

            Presenter.PrintStatusForQueue(smartQueueForDutch, "SmartQueue filled up.");

            smartQueueForDutch.Dequeue();
            smartQueueForDutch.Dequeue();
            smartQueueForDutch.Dequeue();
            smartQueueForDutch.Dequeue();
            Presenter.PrintStatusForQueue(smartQueueForDutch, "queue emptyed with four \"Dequeue()\"");
            Console.WriteLine($" {smartQueueForDutch.ToString()}");

            Console.WriteLine();

            try
            {
                smartQueue.Enqueue("Marcika");
            }
            catch (Exception ex)
            {
                Console.WriteLine($" {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
