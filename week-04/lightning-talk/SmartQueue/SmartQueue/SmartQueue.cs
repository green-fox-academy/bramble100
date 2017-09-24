using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartQueue
{
    public class SmartQueue : Queue
    {
        AllowedMonarchs allowedMonarchs;
        public SmartQueue(Country country = Country.ChuckNorris)
        {
            allowedMonarchs = new AllowedMonarchs(country);
            // His Majesty, Chuck, enters the queue
            Enqueue(allowedMonarchs.First());
        }
        public void Enqueue() // for Chuck
        {
            base.Enqueue(allowedMonarchs.First());
        }
        public override void Enqueue(object newMonarch)
        {
            string newMonarchString = newMonarch.ToString();
            if (allowedMonarchs.Contains(newMonarchString))
            {
                base.Enqueue(newMonarchString);
            }
            else
            {
                throw new ArgumentException(
                    $"Sorry, {newMonarch} is not allowed to join the queue.");
            }
        }
        public override object Dequeue()
        {
            string dequeuedMonarch = base.Dequeue().ToString();
            if (this.Count == 0)
            {
                Enqueue(allowedMonarchs.First()); // Chuck must remain
            }
            return dequeuedMonarch;
        }
        public override string ToString()
        {
            if(Count == 1)
            {
                return "Only Chuck stands in the queue.";
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("These are the monarchs standing in the queue:");
            foreach (string monarch in this)
            {
                sb.AppendLine($" {monarch}");
            }
            return sb.ToString();
        }
    }
}
