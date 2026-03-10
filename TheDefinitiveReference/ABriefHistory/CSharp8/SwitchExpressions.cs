using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp8
{
    // You can use switch in the context of an expression
    internal class SwitchExpressions
    {
        public static void Run()
        {
            int cardNumber = 1;

            // Switch expression
            // This evaluates to a value
            string cardName = cardNumber switch
            {
                13 => "King",
                12 => "Queen",
                11 => "Jack",
                _ => "Pip card"
            };
         
            // Older style (switch statement)
            // Statements do something, but don't directly produce a value (e.g if, switch, for, while return)
            switch (cardNumber)
            {
                case 13:
                    cardName = "King";
                    break;

                case 12:
                    cardName = "Queen";
                    break;

                case 11:
                    cardName = "Jack";
                    break;

                default:
                    cardName = "Pip card";
                    break;
            }
        }
    }
}
