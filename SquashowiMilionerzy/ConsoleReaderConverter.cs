using System;
using System.Collections.Generic;
using System.Text;

namespace SquashowiMilionerzy
{
    class ConsoleReaderConverter
    {
        public char ReadChar()
        {
            bool success = false;
            char result = ' ';
            while (success == false)
            {
                success = char.TryParse(Console.ReadLine().ToLower().Trim(),out result );

                if (success == false)
                {
                    Console.WriteLine("Wpisz jeden znak");
                }
            }
            return result;
        }
    }
}
