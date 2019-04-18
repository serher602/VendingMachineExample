using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj3_Hernandez
{
    /// <summary>
    /// Simulate a candy bar vending machine that starts with
    /// 5 candy bars, where each candy bar costs 3 quarters.
    /// </summary>

    public class VendingMachine
    {
        // private instance variables
        private int numQuarters, numCandyBars, twixBar, kitkatBar, hersheysBar, reesesCups;

        // Public noarg constructor
        public VendingMachine()
        {
            // Set the candy bar cost in quarters.
            numQuarters = 3;

            // Set initial number of candy bars.
            twixBar = 2;
            kitkatBar = 2;
            hersheysBar = 2;
            reesesCups = 2;
            numCandyBars = 0;
        }

        // Public read only properties:

        public int NumQuarters
        {
            get { return numQuarters; }
        }

        public int NumCandyBars
        {
            get { return numCandyBars; }
        }

        public int TwixBar
        {
            get { return twixBar; }
        }

        public int KitkatBar
        {
            get { return kitkatBar; }
        }
        public int HersheysBar
        {
            get { return hersheysBar; }
        }
        public int ReesesCups
        {
            get { return reesesCups; }
        }

        // Public methods:

        public string DepositQuarter()
        {
            numQuarters++;
            return "Quarter deposited.";
        }


        // 4 Different Select Methods for each candy bar
        public string SelectTwix()
        {
            if (numQuarters >= 3 && twixBar > 0)
            {
                numQuarters = numQuarters - 3;
                twixBar = twixBar - 1;
                numCandyBars = numCandyBars +  1;
                return "Twix bar dispensed";
            }
            else if (twixBar > 0)
            {
                return "Not enough quarters to buy a Twix bar.";
            }
            else
            {
                return "No Twix bars in machine.";
            }

        }

        public string SelectKitkat()
        {
            if (numQuarters >= 4 && kitkatBar > 0)
            {
                numQuarters = numQuarters - 4;
                kitkatBar = kitkatBar - 1;
                numCandyBars = numCandyBars + 1;
                return "KitKat bar dispensed";
            }
            else if (kitkatBar > 0)
            {
                return "Not enough quarters to buy a KitKat bar.";
            }
            else
            {
                return "No KitKat bars in machine.";
            }

        }

        public string SelectHersheys()
        {
            if (numQuarters >= 5 && hersheysBar > 0)
            {
                numQuarters = numQuarters - 5;
                hersheysBar = hersheysBar - 1;
                numCandyBars = numCandyBars + 1;
                return "Hershey's bar dispensed";
            }
            else if (hersheysBar > 0)
            {
                return "Not enough quarters to buy a Hershey's bar.";
            }
            else
            {
                return "No Hershey's bars in machine.";
            }

        }

        public string SelectReeses()
        {
            if (numQuarters >= 6 && reesesCups > 0)
            {
                numQuarters = numQuarters - 6;
                reesesCups = reesesCups - 1;
                numCandyBars = numCandyBars + 1;
                return "Reese's Cups dispensed";
            }
            else if (reesesCups > 0)
            {
                return "Not enough quarters to buy a Reese's Cups.";
            }
            else
            {
                return "No Reese's Cups in machine.";
            }

        }


        // ToString Method
        public override string ToString()
        {

            return "Total Quarters: " + numQuarters + " Total Bars:" + numCandyBars +
             " Twix Bars:" + twixBar + " KitKat Bars:" + kitkatBar + " Hershey Bars:"
            + hersheysBar + " Reese's Cups:" + reesesCups;
        }
    }

}
