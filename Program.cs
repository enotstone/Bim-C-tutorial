using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region // act 1-7
            #region //act 1 
            /*
            int a, b, sum;
            a = 5;
            b = 10;
            sum = a + b;
            Console.WriteLine("1 слогаемое {0}. 2 слогаемое {1}. Summa {2}", a, b, sum);
            Console.WriteLine("Press any key");
            Console.Read(); */
            #endregion
            #region //act 2 
            /*
            Console.WriteLine("Enter circumference:");
            double L = Convert.ToDouble(Console.ReadLine());
            double Radius = (L / Math.PI / 2);
            double Square = Math.PI * Math.Pow(Radius, 2);
            Console.WriteLine("Площадь круга равна {0}, а диаметр равен {1}", Math.Round(Square, 2), Math.Round(Radius * 2,2));
            Console.WriteLine("Press any key");
            Console.ReadKey(); */
            #endregion
            #region //act 3.1
            /*
            int x1, x2, x3, x4, y1, y2, y3, y4;
            Console.WriteLine("Введите первую целочисленную координату вершины прямоугольника оси Х:");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите первую целочисленную координату вершины прямоугольника оси Y:");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вторую целочисленную координату вершины прямоугольника оси Х:");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вторую целочисленную координату вершины прямоугольника оси Y:");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третью целочисленную координату вершины прямоугольника оси Х:");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третью целочисленную координату вершины прямоугольника оси Y:");
            y3 = Convert.ToInt32(Console.ReadLine());
            y4 = x4 = 0;
            if (x1 == x2)
            {
                if (y3 == y2)
                {
                    y4 = y1;
                    x4 = x3;
                }
                else if (y3 == y1)
                {
                    x4 = x3;
                    y4 = y2;
                }
                else Console.WriteLine("Невереные координаты");
            }
            else if (x2 == x3)
            {
                if (y3 == y2)
                {
                    x4 = x1;
                    y4 = y1;
                }
                else if (y3 == y1)
                {
                    x4 = x1;
                    y4 = y2;
                }
                else Console.WriteLine("Невереные координаты");
            }
            else if (x1 == x3)
            {
                if (y3 == y2)
                {
                    x4 = x2;
                    y4 = y1;
                }
                else if (y3 == y1)
                {
                    x4 = x2;
                    y4 = y2;
                }
                else Console.WriteLine("Невереные координаты");
            }
            else Console.WriteLine("Невереные координаты");


            string answer = (x4 == 0) ?  "Ошибка" : "Координата Х,У четвертой вершины: " + x4 + "," + y4;


            Console.WriteLine(answer);
            Console.ReadKey(); */
            #endregion
            #region //act 3.2
            /*
            int age;
            string age_yard = "Error";
            Console.WriteLine("Введите число от 20-69:");
            age = Convert.ToInt32(Console.ReadLine());
            string a = age.ToString().Substring(1, 1);
            int n = Convert.ToInt32(a);
            if (n == 1)
                {
                age_yard = "год";
                }
            else if (n > 4 || n == 0)
                {
                age_yard = "лет";
                }
            else
                {
                age_yard = "года";
                }
            
            string answer = (age < 20 || age > 69) ? "Число за пределами 20-69" : Convert.ToString(age)+" "+ age_yard;
            Console.WriteLine(answer);
            Console.ReadKey(); */
            #endregion
            #region //act 4
            /*
            int i = 1;
            int Sum = 0;
            int N = Convert.ToInt32(Console.ReadLine());
            do
            {
                int Square = 2 * i - 1;
                Sum = Sum + Square;
                Console.WriteLine(Sum);
                i++;
            } while (i <= N); 
            Console.ReadKey(); */
            #endregion
            #region //act 5.1
            /*
            int[] arraySA = new int[7];
            float Sum = 0;
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Введите целое число:");
                arraySA[i]= Convert.ToInt32(Console.ReadLine());
                Sum = Sum + arraySA[i];
            }
            Console.WriteLine("{0:f2}",Sum/7);
            Console.ReadKey();
            */
            #endregion
            #region //act 5.2
            /*
            Console.WriteLine("Введите целое число:");
            int n = Convert.ToInt32(Console.ReadLine());
            bool[,] array = new bool[n,n];
            bool x = true;
            for (int i = 0; i < n; i++)
            {
                
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = x;
                    x = !x;
                    Console.Write("{0,2}", Convert.ToInt32(array[i, j])); 
                }
                x = (n % 2 == 0) ? !x: x;
                Console.WriteLine();
            }
            Console.ReadKey(); */
            #endregion
            #region //act 6.1
            /*
            Console.WriteLine(" Ввести с клавиатуры предложение. \n Предложение представляет собой слова, разделенные пробелом. \n Знаки препинания не используются.");
            String Phrase = Console.ReadLine();

            string[] words = Phrase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int LStr1, LStr2;
            LStr1 = 0;
            String Slong = "";
            foreach (string s in words)
            {
                LStr2 = s.Length;
                LStr1 = (LStr2 > LStr1) ? LStr2: LStr1;
                Slong = (LStr2 == LStr1) ? s: Slong;
            }
            Console.WriteLine(Slong+"самое длинное слово в строке "+ LStr1+" символов");
            Console.ReadKey();
            */
            #endregion
            #region //act 6.2
            /*
            Console.WriteLine(" Ввести с клавиатуры предложение. \n Предложение представляет собой слова, разделенные пробелом. \n Знаки препинания не используются.");
            String Phrase = Console.ReadLine();
            Phrase = Phrase.ToLower();
            int LStr = Phrase.Length;
            bool b = true;
            for (int i = 0; i < Phrase.Length / 2; i++)
            {
                b = (Phrase[i] == Phrase[Phrase.Length - i - 1]) ? b : !b;
                if (b == false)
                    break;
            }
            Console.WriteLine(((b != true) ? "не является" : "является") + " полиндромом");
            Console.ReadKey();*/
            #endregion
            #region //act 7.1
            /*
            int[] STr = new int[2];
            for (int i = 0; i < 2; )
            {
                Console.WriteLine(" Введите три стороны треугольника");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());
                STr[i] = CalcSquare(a, b, c);
                i++;
            }
            Console.WriteLine((STr[0] > STr[1]) ? "Площадь 1 треугольника больше": "Площадь 2 треугольника больше");
            Console.ReadKey();*/
            #endregion
            #region //act 7.2

            Console.WriteLine(" Введите сторону куба");
            double a = Convert.ToDouble(Console.ReadLine());
            double PCube, SCube;
            CalcCube(a, out PCube, out SCube);
            Console.WriteLine("Объем куба: " +SCube+"м3 Площадь куба: "+PCube+"м2");
            Console.ReadKey();
            #endregion
            #endregion
        }
        static void CalcCube(double a, out double P, out double S)
        {
            P = (a*a)*6;
            S = a*a*a;
            
        }
    }
}
