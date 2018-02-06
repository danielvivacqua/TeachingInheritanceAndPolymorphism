using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Standard : Membership
    {
        //fields
        //invisible

        //Properties
        public int Cost { get; set; }

        //Constructors
        public Standard()
        {
            //default constructor
        }

        public Standard(int cost) //overloaded constructor
        {
            Cost = cost;
        }

        //Methods
        public override void Activate()
        {
            if (IsActive == false)
            {
                IsActive = true;
                Console.WriteLine("Your standard membership has been activated.");
            }
            else
            {
                Console.WriteLine("Your standard membership is already active.");
            }
        }
    }
}
