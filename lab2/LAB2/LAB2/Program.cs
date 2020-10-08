using System;
using System.Text;

namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Типы
             Console.WriteLine("-----Типы------");
             //value type 
             bool boolT = false; //Логический true/false
             //Целочисленные
             byte byteT = 200; // 0 - 255 | размер 1 байта
             sbyte sbyteT = -100; //-128 - 127 | 1
             short shortT = 32767; // от -32768 до 32767 | 2
             ushort ushortT = 64342; //от 0 до 65535 | 2
             int intT = 23441412; // от -2147483648 до 2147483647 | 4
             uint uintT = 343243342; // от 0 до 4294967295 | 4
             long longT = 24241241124124; // многацыфр | 8
             ulong ulongT = 1242345893458234254; // столько же многа, но все положительные | 8
             // uint и ulong хранят только положительные числа, хотя их диапазоны с int и long совпадают
             //Символьный
             char charT = 'A'; // символ ('')| 2
             //Числовые
             decimal decT = 2.4325224412412124121m; // десятичное дробное число, может хранить 28 знаков после запятой | 16
             double doubT = 2.42132131212; // хранит число с плавающией точкой, 16 знаков | 8
             float floatT = 2.32324f; //хранит число с плавающей точкой, 8 знакоы | 4

             //implicit conversion (неявное приведение)
             int impCInt = 2454354;
             long impCLong = impCInt;

             short impCShort = 2324;
             impCInt = impCShort;

             uint impCUint = 421312321;
             impCLong = impCUint;

             byte impCByte = 120;
             impCShort = impCByte;

             ushort impCUshort = 23424;
             impCInt = impCUshort;

             //Explicit conversion (явное приведение)
             double expCDouble = 23345.3;
             int expCInt = (int)expCDouble;

             sbyte expCSbyte = 120;
             byte expCByte = (byte)expCSbyte;

             float expCFloat = 23.42342f;
             expCDouble = expCFloat;

             decimal expCDec = (decimal)expCDouble;

             expCByte = (byte)expCFloat;

             //Convert - способ для преобразования значений

             int n = Convert.ToInt32("8");
             bool b = true;
             double d = Convert.ToDouble(b);
             Console.WriteLine("Класс convert: n=" + n + " d=" + d);

             //boxing and unboxing (упаковка и распаковка)
             //Когда любой значимый тип присваивается к ссылочному типу данных, значение перемещается из области стека в кучу. Эта операция называется упаковкой.
             //Когда любой ссылочный тип присваивается к значимому типу данных, значение перемещается из области кучи в стек. Это называется распаковкой.
             int boxingInt = 8;
             object intBox = boxingInt;
             int unboxingInt = (int)intBox;

             // неявная типизация 
             var VarInt = 5;
             var VarStr = "Hello!";
             Console.WriteLine("Тип неявно типизированной переменной -  " + VarInt.GetType());
             Console.WriteLine("Тип неявно типизированной переменной -  " + VarStr.GetType());

             //Nullable используется если заранее неизвестно, какое значение примет переменная
             int? nullInt1 = 8;
             int? nullInt2 = null;
             Console.WriteLine("Переменная nullInt хранит значение - " + nullInt1.HasValue);
             Console.WriteLine("Переменная nullInt хранит значение - " + nullInt2.HasValue);

             var V = 8;
             //V = "Hello"; //мы не можем сначала объявить неявно типизируемую переменную, а затем инициализировать ее
             Console.ReadLine();
             Console.Clear();

             //2) Строки
             Console.WriteLine("-----Строки-----");
             string s1 = "hello";
             string s2 = "world";
             string s3 = String.Copy(s1);//копирование
             string s4 = s1 + " " + s2;//сцепление(hello world)
             //сравнение
             Console.WriteLine(String.Compare(s1, s2) == 0 ? "Строки совпадают" : "Строки не совпадают");
             string[] words = s3.Split(new char[] { ' ' });//разделение строки на слова(в массив)

             string subS1 = s4.Substring(6);//Выделяется подстрока с 7 символ
             Console.WriteLine("Подстрока: " + subS1);
             Console.WriteLine("Вставка подстроки: " + s2.Insert(5, subS1));

             int x = s4.IndexOf(subS1);//определяет первое вхождение подстроки 
             Console.WriteLine("Удаление подстроки: " + s4.Remove(x, subS1.Length));

             string nStr = null, fStr = "";
             Console.WriteLine(string.IsNullOrEmpty(nStr));

             StringBuilder strB1 = new StringBuilder("Привет мир");
             StringBuilder strB2 = new StringBuilder("Привет мир");
             Console.WriteLine("Вставка: " + strB1.Insert(0, "!!!").AppendFormat("!!!"));
             Console.WriteLine("Удаление: " + strB2.Remove(6, 4));
             Console.ReadLine();
             Console.Clear();
             //3) Массивы
             Console.WriteLine("-----Массивы-----");
             int[,] ArrM = { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 } };
             int rows = ArrM.GetUpperBound(0) + 1;
             int columns = ArrM.Length / rows;
             Console.WriteLine("Матрица:");
             for (int i = 0; i < rows; i++)
             {
                 for (int j = 0; j < columns; j++)
                 {
                     Console.Write($"{ArrM[i, j]} \t");
                 }
                 Console.WriteLine();
             }
             Console.WriteLine();
             string[] ArrS = { "Hello", "world", "!!!" };
             foreach (string i in ArrS)
                 Console.Write($"{i} ");
             Console.WriteLine();
             Console.WriteLine("Длина массива строк: " + ArrS.Length);
             Console.WriteLine("Введите элемент, который хотите заменить(0-2):");
             int numb = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Введите текст для замены:");
             string newS = Console.ReadLine();
             ArrS[numb] = ArrS[numb].Replace(ArrS[numb], newS);
             Console.WriteLine("Новый массив:");
             foreach (string i in ArrS)
                 Console.Write($"{i} ");
             Console.WriteLine();
             int[][] myArr = new int[3][];
             myArr[0] = new int[2];
             myArr[1] = new int[3];
             myArr[2] = new int[4];
             int lan = 2;
             for (int k = 0; k < 3; k++)
             {
                 Console.WriteLine("Введите элементы " + k + " строки массива" );
                 for(int l = 0; l < lan; l++)
                 {
                     myArr[k][l] = Convert.ToInt32(Console.ReadLine());
                 }
                 lan++;
             }
             Console.WriteLine();
             Console.WriteLine("Ваш массив:");
             lan = 2;
             for (int k = 0; k < 3; k++)
             {
                 for (int l = 0; l < lan; l++)
                 {
                     Console.Write(myArr[k][l] + " ");
                 }
                 lan++;
                 Console.WriteLine();
             }

             var AArr = new[] { "A", "A", "A", "A" }; 
             var NumArr = new[] { 1, 2, 3, 4, 5 };

             Console.ReadLine();
             Console.Clear();

             //4) кортежи
             Console.WriteLine("-----Кортежи-----");

             //(int, string, char, string, ulong)
             var tuple = (5, "A", 'A', "AAA", 1242345893458234254);

             Console.WriteLine("Кортеж:\n" + tuple.Item1); 
             Console.WriteLine(tuple.Item2);
             Console.WriteLine(tuple.Item3);
             Console.WriteLine(tuple.Item4);
             Console.WriteLine(tuple.Item5);

             var (v1, v2, v3, v4, v5) = tuple;
             (int iv1, string sv2, char cv3, string sv4, var ulv5) = tuple;
             var (v11, _, v13, _, _) = tuple;//вторая, четвертая и пятая переменная не будут распакованы

             var t1 = (A: 5, B: 10);
             var t2 = (B: 5, A: 10);
             Console.WriteLine(t1 == t2);  // output: True
             Console.WriteLine(t1 != t2);  // output: False

             Console.ReadLine();
             Console.Clear();
             
            Console.WriteLine("-----Локальная функция-----");

            (int, int, int, char) Tfunc(int[] intArr, string newStr)
            {
                int max = 0;
                int min = 99;
                int sum = 0;
                for (int i = 0; i < intArr.Length; i++)
                {
                    sum += intArr[i];
                    if (intArr[i] <= min)
                    {
                        min = intArr[i];
                    }
                    if (intArr[i] >= max)
                    {
                        max = intArr[i];
                    }
                }

                (int, int, int, char) Ftuple = (max, min, sum, newStr[0]);
                return Ftuple;
            }

            int[] funcArr = new int[] { 3, 4, 5, 6, 7, 8, 9, 10 };
            string funcStr = "Hello";
            (int, int, int, char) funcTuple = Tfunc(funcArr, funcStr);

            Console.WriteLine("Новый кортеж:\n" + funcTuple.Item1);
            Console.WriteLine(funcTuple.Item2);
            Console.WriteLine(funcTuple.Item3);
            Console.WriteLine(funcTuple.Item4);

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("-----checked/unchecked-----");

            int checkFunc()
            {
                checked
                {
                    int maxInt = 2147483647;
                    //maxInt++; //выдаст ошибку
                    return maxInt;

                }
            }

            int uncheckFunc()
            {
                unchecked
                {
                    int maxInt = 2147483647;
                    maxInt++; //число станет отрицательным
                    return maxInt;
                }

            }

            Console.WriteLine(checkFunc());
            Console.WriteLine(uncheckFunc());
        }

        
    }
}
