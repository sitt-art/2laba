using System;
using System.Text;
using System.Linq;

namespace _2лаба
{
    class Program
    {
        static void Main(string[] args)
        {
     //первое задание а
            bool alive = true;
            bool isDead = false;
            byte bit1 = 1;
            sbyte bit2 = -101;
            short n1 = 1;
            ushort n = 1;
            int hu = 10;
            uint aha = 10;
            long afu = -10;
            ulong aoy = 10;
            float fifi = (float)1.2;
            double fafi = 1.3;
            decimal fufu = (decimal)4.654;
                char b = '\x5A';
            string hello = "Hello";
            object c = "hello code";

            //б
            // неявные преобразования типов
            int nik = 147372722;
            long kil = nik;
            float fik = nik;
            double kid = nik;
            decimal rit = nik;
            double gif = kil;

            // явные преобразования типов
            double git = 156.18282828488321;
            int hit = (int)git;
            float fig = (float)14.6;
            decimal rim = (decimal)123.8;
            long kim = (long)124.684;
            uint hitig = (uint)23.75833;

            //c Выполните упаковку и распаковку значимых типов, 
            int figa = 123123;
            object y = figa; // упаковка figa в y
            int wiy = (int)y; // распаковка y в wiy

            //d  неявно типизированной переменной, тут само определяет тип с вар
            int krja = 1234;
            var krj = 1234;
            var kr = 12.34;

            //e. Продемонстрируйте пример работы с Nullable переменной.
            int? gitit = 654;
            // shot примет значение gitit, если оно есть, иначе использовать значение по умолчанию, которое задано после "??"
            int shot = gitit ?? 7;
            // GetValueOrDefault - взять значение, если оно есть, иначе использовать значение по умолчанию (скорее всего 0)
            Console.WriteLine($"значение {gitit.GetValueOrDefault()}");

            if (gitit.HasValue)
            {
                Console.WriteLine($"есть значение {gitit.Value}");

            }
            else
            {
                Console.WriteLine($"НЕТ значение");
            }
            //2 задание
            //a. Объявите строковые литералы. Сравните их
            Console.WriteLine("nir" == "nid");
            Console.WriteLine("nir".CompareTo("nid"));

            //b. Создайте три строки на основе String. Выполните: сцепление,
            //копирование, выделение подстроки, разделение строки на слова,
            //вставки подстроки в заданную позицию, удаление заданной подстроки
            string miy = "miymiymiy";
            string gav = "miymiymav";
            string gah = "miymigmav";

            //сцепление
            string fiho = miy + " " + gav + " " + gah;

            //копирование
            string gaf = String.Copy(fiho);

            //выделение подстроки
            string diyt = fiho.Substring(0, 8);

            //разделение строки на слова
            var split = fiho.Split(' ');

            //вставки подстроки в заданную позицию
            fiho.Insert(9, "nuuuuuuuulllll");

            //удаление заданной подстроки
            var index = fiho.IndexOf(miy);
            fiho.Remove(index, miy.Length + index);

            //c. Создайте пустую и null строку. Продемонстрируйте что можно выполнить с такими строками
            string nulle = "";
            string nullel = null;
            //Console.WriteLine(nullel.Length); // -- будет ошибка при выполнении программы
            Console.WriteLine(nulle.Length); //все будет хорошо и вернется 0
                                             // String.IsNullOrEmpty(nulle) - проверка на то пуста ли строка nulle или равна ли она null

            //d. Создайте строку на основе StringBuilder. Удалите определенные 
            //позиции и добавьте новые символы в начало и конец строки
            //
            StringBuilder sb = new StringBuilder("ABCD ee fff ghh kkk", 50);
            sb.Replace("ghh", "");//заменить гн на пустоту
            sb.Append("chle");//добавить в конец
            sb.Insert(0, "Alp: ");//встить в начало с позиции 0

            //3 Массивы
            //a. Создайте целый двумерный массив и выведите его на консоль в
            //отформатированном виде(матрица). 
            int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            int rows = mas.GetUpperBound(0) + 1;//rows -строки и считаем их количество с гет...
            int columns = mas.Length / rows; //column - столбцы
            // или так
            // int columns = mas.GetUpperBound(1) + 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas[i, j]} \t");
                }
                Console.WriteLine();
            }
            //b.Создайте одномерный массив строк. Выведите на консоль его
            //содержимое, длину массива. Поменяйте произвольный элемент
            //(пользователь определяет позицию и значение)
            string[] mass = { "bimo", "bingo", "dino" };
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");

            }
            Console.WriteLine();
            Console.WriteLine($"длина = {mass.Length}");

            int indexSlova = -1;

            while (indexSlova < 0 || indexSlova > mass.Length - 1)
            {
                Console.WriteLine($"Введите индекс слова, которое хотите заменить [0;{mass.Length - 1}]");
                indexSlova = int.Parse(Console.ReadLine());//int.Parse - преобразовать в  инт из строки; ReadLine - считать строку из консоли
            }

            Console.WriteLine("Введите строку, на которую хотите произвести замену");
            string novoeSlovo = Console.ReadLine();

            mass[indexSlova] = novoeSlovo;

            Console.WriteLine("Полученный массив строк");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }

            Console.WriteLine();

            //c. Создайте ступечатый (не выровненный) массив вещественных
            //чисел с 3 - мя строками, в каждой из которых 2, 3 и 4 столбцов
            //соответственно.Значения массива введите с консоли.
            double[][] doubleArray = new double[3][];
            doubleArray[0] = new double[2];
            doubleArray[1] = new double[3];
            doubleArray[2] = new double[4];

            Console.WriteLine("Введите значения элементов ступенчатого массива (пример элемента: 1,2)");

            for (int i = 0, rows1 = doubleArray.GetUpperBound(0) + 1; i < rows1; i++) //GetUpperBound(0) - получить последний дейст.индекс нулвого измерения 
            {
                for (int j = 0; j < doubleArray[i].Length; j++)
                {
                    Console.WriteLine($"a[{i}][{j}]:");
                    
                    doubleArray[i][j] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Полученный ступенчатый массив");
            for (int i = 0, rows1 = doubleArray.GetUpperBound(0) + 1; i < rows1; i++)
            {
                for (int j = 0; j < doubleArray[i].Length; j++)
                {
                    Console.Write($"{doubleArray[i][j]} ");   
                }
                Console.WriteLine();
            }

            //d.Создайте неявно типизированные переменные для хранения массива и строки
            var someArray = doubleArray;
            var pervayaStroka = doubleArray[0];

            // Кортежи
            //  a.Задайте кортеж из 5 элементов с типами int, string, char, string, ulong.
            (int, string, char, string, ulong) tuple = (0, "1", '2', "3", 4);
            // b.Выведите кортеж на консоль целиком и выборочно(например 1,3, 4 элементы)
            Console.WriteLine("Весь кортеж");
            Console.WriteLine(tuple);
            Console.WriteLine("1, 3, 4 элементы кортежа");
            Console.WriteLine($"{tuple.Item1}, {tuple.Item3}, {tuple.Item4}");
            // c.Выполните распаковку кортежа в переменные
            (int t1, string t2, char t3, string t4, ulong t5) = tuple;
            (int, string, char, string, ulong) tuple1 = (1, "1", 'a', "4", 5);
            Console.WriteLine($"Сравнение картежей tuple={tuple} и tuple1={tuple1}. Кортежи равны? - {tuple == tuple1}");

            // 6. Создайте локальную функцию в main и вызовите ее.Формальные
            //параметры функции – массив целых и строка. Функция должна вернуть
            // кортеж, содержащий: максимальный и минимальный элементы массива,
            // сумму элементов массива и первую букву строки.

            (int, int, int, char) customFunc(int[] array, string stroka)
            {
                var max = array.Max();
                var min = array.Min();
                var sum = array.Sum();
                var h1bukvastroki = stroka.First();

                return (max, min, sum, h1bukvastroki);
            }

            Console.WriteLine("Тестирование написанной функции");
            int[] intArray = { 1, 6, -30, 435, -14, 0 };
            string novayaStroka = "BBoy";
            Console.WriteLine($"Параметры, переданные в функцию:");
            Console.Write("[");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write($"{intArray[i]} ");
            }
            Console.WriteLine("]");
            Console.WriteLine(novayaStroka);
            var resultFunc = customFunc(intArray, novayaStroka);
            Console.WriteLine($"Результат работы функции: {resultFunc}");
        }
    }
}
