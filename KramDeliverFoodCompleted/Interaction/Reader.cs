using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KramDeliverFoodCompleted.Interaction
{
    public class Reader
    {
        public virtual int MakeInput()
        {
            var result = 0;

            while (true)
            {
                var input = Console.ReadLine();

                if (int.TryParse(input, out result))
                {
                    if (input.Length != 1)
                    { 
                        Logger.RepeatInput();

                        continue;
                    }

                    break;
                }
            }

            return result;
        }
    }
}
