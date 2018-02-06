using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class VIP : Membership
    {
        //fields
        //invisible

        //Properties
        public bool IsSwanky { get; set; }

        //Constructors
        public VIP()
        {
            //default constructor
        }

        public VIP(bool isSwanky)
        {
            this.IsSwanky = isSwanky;
        }

        //Methods
        public override void Activate()
        {
            IsSwanky = true;

            if (IsActive == false)
            {
                IsActive = true;
                Console.WriteLine("You are now a big deal.");
            }
            else
            {
                Console.WriteLine("You're already a big deal.");
            }
        }
    }
}
