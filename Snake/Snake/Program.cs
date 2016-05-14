using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 5;
            int y1 = 6;
            char s1 = '*';

            Draw(x1, y1, s1);

            int x2 = 7;
            int y2 = 9;
            char s2 = '@';

            Draw(x2, y2, s2);

            Console.ReadLine();
        }

        static void Draw(int x, int y, char s)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }
    }
}
