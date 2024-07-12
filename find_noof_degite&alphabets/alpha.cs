using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_noof_degite_alphabets
{
    internal class alpha
    {
        string name = "";
        int alphabets = 0;
        int numbers = 0;
        public void Input()
        {
            Console.WriteLine("Enter a name with some degite: ");
            name = Console.ReadLine();
        }
        public void process()
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i]>='A' &&  name[i]<='Z' ||  name[i]>='a' && name[i] <= 'z')
                {
                    alphabets++;
                }
                else if (name[i] >= '0' && name[i] <= '9')
                {
                    numbers++;
                }
            }

        }
        public void output()
        {
            Console.WriteLine("alphabets = "+alphabets);
            Console.WriteLine("degite = "+numbers);
        }
    }
}
