using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace piano
{
    internal class Program
    {
        static int[] change(int num)
        {
            int[] firstOctave = new int[] { 32, 34, 36, 38, 41, 43, 46, 49, 51, 55, 58, 61 };
            int[] firstOctave7u = new int[] { 32, 34, 36, 38, 41, 43, 46, 49, 51, 55, 58, 61 };
            int[] firstOctaveuhh = new int[] { 32, 34, 36, 38, 41, 43, 46, 49, 51, 55, 58, 61 };

            if (num == 1)
            {
                return firstOctave;
            }
            else if (num == 2)
            {
                return firstOctave7u;
            }
            else
            {
                return firstOctave;
            }
        }
        static void Main()
        {
            Console.WriteLine("Держите ваше пианино [^.^]");
            Console.WriteLine("Переключение между актавами - F1 и F2");
            Console.WriteLine("Black клавиши B, D, F, H, J");
            Console.WriteLine("White клавиши A, C, E, G, I, K, M");
            Console.WriteLine("На данный момент включена 1 актава :3");
            int[] a = change(3);
             












            

        }
    }
}
