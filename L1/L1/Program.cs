using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Написать программу “Анкета”. Последовательно задаются вопросы (имя, фамилия, возраст,
рост, вес). В результате вся информация выводится в одну строчку.
а) используя  склеивание;
б) используя форматированный вывод.
1. Ввести вес и рост человека. Расчитать и вывести индекс массы тела(ИМТ) по формуле
I=m/(h*h); где m­масса тела в килограммах, h ­ рост в метрах
*Интерпритировать показания ИМТ.
3. а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1
и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2­x1,2)+Math.Pow(y2­y1,2). Вывести результат
используя спецификатор формата .2f (с двумя знаками после запятой);
© geekbrains.ru 21
б) *Выполните предыдущее задание оформив вычисления расстояния между точками в виде
метода;
4. Написать программу обмена значениями двух переменных
а) с использованием третьей переменной;
б) *без использования третьей переменной.
5. а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) *Сделайте задание, только вывод организуйте в центре экрана
в) **Сделайте задание  б с использованием собственных методов (например, Print(string ms, int
x,int y)
6. Создайте класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).
 *
 */
namespace L1
{
    class Program
    {
        public static double IMT (double h, double mass)
        {
            return mass / (h * h);            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Print your name");
            string name = Console.ReadLine();
            Console.WriteLine("Print your surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Print your age");
            double age = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Print your heigth");
            double heigth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Print your weigth");
            double weigth = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Hello, {surname} {name}! {age};{heigth};{weigth}");
            double I = IMT(heigth, weigth);
            Console.WriteLine($"your IMT = {I}");
            Console.ReadKey();
         



        }
    }
}
