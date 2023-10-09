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
            int[] firstOctave = new int [] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
            int[] secondOctave = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
            int[] thirdOctave = new int[] { 2093, 2217, 2349,2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951   };

            if (num == 1)
            {
                return firstOctave;
            }
            else if (num == 2)
            {
                return secondOctave;
            }
            else
            {
                return thirdOctave;
            }
        }
        static void Main()
        {
            Console.WriteLine("Держите ваше пианино [^.^]");
            Console.WriteLine("Переключение между актавами - F1, F2, F3");
            Console.WriteLine("Black клавиши B, D, F, H, J");
            Console.WriteLine("White клавиши A, C, E, G, I, K, M");
            Console.WriteLine("На данный момент включена 1 актава :3");
            int[] a = change(1);
            ConsoleKeyInfo klavv = Console.ReadKey(true);
            do
            {
                switch (klavv.Key)
                {
                    case ConsoleKey.F1:
                        Console.WriteLine("Это первая октава");
                        a = change(1);
                        break;
                    case ConsoleKey.F2:
                        Console.WriteLine("Это вторая актаваа");
                        a = change(2);
                        break;
                    case ConsoleKey.F3:
                        Console.WriteLine("Это третья актавааа");
                        a = change(3);
                        break;
                    case ConsoleKey.A:
                        Console.Beep(a[0], 100);
                        break;
                    case ConsoleKey.B:
                        Console.Beep(a[1], 100);
                        break;
                    case ConsoleKey.C:
                        Console.Beep(a[2], 100);
                        break;
                    case ConsoleKey.D:
                        Console.Beep(a[3], 100);
                        break;
                    case ConsoleKey.E:
                        Console.Beep(a[4], 100);
                        break;
                    case ConsoleKey.F:
                        Console.Beep(a[5], 100);
                        break;
                    case ConsoleKey.G:
                        Console.Beep(a[6], 100);
                        break;
                    case ConsoleKey.H:
                        Console.Beep(a[7], 100);
                        break;
                    case ConsoleKey.I:
                        Console.Beep(a[8], 100);
                        break;
                    case ConsoleKey.J:
                        Console.Beep(a[9], 100);
                        break;
                    case ConsoleKey.K:
                        Console.Beep(a[10], 100);
                        break;
                    case ConsoleKey.M:
                        Console.Beep(a[11], 100);
                        break;

                }
                klavv = Console.ReadKey(true);


            } while (klavv.Key != ConsoleKey.Escape);
          
            
            

            

            
}   }   }
 
