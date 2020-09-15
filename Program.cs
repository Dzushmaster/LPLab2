using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lab1
{
    class Program
    {
        static int ForChecked()
        {
            int Max;
            checked
            {
                Max = int.MaxValue;
            }
            return Max;
        }
        static int ForUnchecked()
        {
            int Max;
            unchecked
            {
                Max = int.MaxValue + 3;
            }
            return Max;
        }
        static void Main()
        {
            Console.WriteLine("---------Типы---------");
            bool boolType = false;
            byte byteType = 255;
            sbyte sbyteType = -127;
            char charType = 'c';
            decimal decimalType = 12.3m;
            double doubleType = 12.3;
            float floatType = 12.3f;
            int intType = -32656;
            uint uintType = 32656;
            long longType = 32656;
            ulong ulongType = 32656;
            short shortType = -32656;
            ushort ushortType = 32656;
            object objectType = "U can use all types";
            string stringType = "it's stringType";
            dynamic dynamicType = "Lives only during compilation";
            //---------------------------------------------------
            Console.WriteLine($"boolType = {boolType}");
            boolType = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine($"byteType = {byteType}");
            byteType = Convert.ToByte(Console.ReadLine());
            Console.WriteLine($"sbyteType = {sbyteType}");
            sbyteType = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine($"charType = {charType}");
            charType = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"decimalType = {decimalType}");
            Console.WriteLine("Numbers with floating point write only with ','");
            decimalType = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"doubleType = {doubleType}");
            doubleType = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("floatType = {0}", floatType);
            floatType = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("intType = {0}", intType);
            intType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("uintType = {0}", uintType);
            uintType = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("longType = {0}", longType);
            longType = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("ulongType = " + ulongType);
            ulongType = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("shortType = " + shortType);
            shortType = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("ushortType = " + ushortType);
            ushortType = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("objectType = " + objectType);
            objectType = Console.ReadLine();
            Console.WriteLine("stringType = " + stringType);
            stringType = Console.ReadLine();
            Console.WriteLine("dynamicType = " + dynamicType);
            dynamicType = Console.ReadLine();
            
            Console.WriteLine("-------------------------------------------------------------------------------------------------------"); ;
            Console.WriteLine($"boolType = {boolType}");
            Console.WriteLine($"byteType = {byteType}");
            Console.WriteLine($"sbyteType = {sbyteType}");
            Console.WriteLine($"charType = {charType}");
            Console.WriteLine($"decimalType = {decimalType}");
            Console.WriteLine($"doubleType = {doubleType}");
            Console.WriteLine("floatType = {0}", floatType);
            Console.WriteLine("intType = {0}", intType);
            Console.WriteLine("uintType = {0}", uintType);
            Console.WriteLine("longType = {0}", longType);
            Console.WriteLine("ulongType = " + ulongType);
            Console.WriteLine("shortType = " + shortType);
            Console.WriteLine("ushortType = " + ushortType);
            Console.WriteLine("objectType = " + objectType);
            Console.WriteLine("stringType = " + stringType);
            Console.WriteLine("dynamicType = " + dynamicType);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");

            
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            byte byteNumber = byte.MaxValue;
            Console.WriteLine("byteNumber = {0}", byteNumber);
            short shortNumber = byteNumber;
            Console.WriteLine("byteNumber -> shortNumber {0}", shortNumber);
            int intNumber = shortNumber;
            Console.WriteLine("shortNumber -> intNumber {0}", intNumber);
            long longNumber = intNumber;
            Console.WriteLine("intNumber -> longNumber {0}", longNumber);
            float floatNumber = float.MaxValue;
            Console.WriteLine("floatNumber = {0}", floatNumber);
            double doubleNumber = floatNumber;
            Console.WriteLine("floatNumber -> doubleNumber {0}", doubleNumber);
            uint uintNumber = int.MaxValue;
            Console.WriteLine("uintNumber -> int {0}", uintNumber);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            //--------------------------------------------------------------------------
            string str = "178,19";
            float single = Convert.ToSingle(str);
            double dbl = Convert.ToDouble(single);
            decimal dec = Convert.ToDecimal(dbl);
            string Intstr = "15";
            byte byt = Convert.ToByte(Intstr);
            short shrt = Convert.ToInt16(byt);
            Console.WriteLine($"String {str} -> float {single} -> double {dbl} -> decimal {dec}\nString {Intstr} -> byte {byt} -> short {shrt}");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            //---------------------------------------------------------------------------
            int toBox = 189;
            object boxing = toBox;
            int toUnbox = (int)toBox;
            //---------------------------------------------------------------------------
            var noType = 5;
            int sum = noType + toBox;
            //noType = true;
            Console.WriteLine("Use implicitly typed variable");
            Console.WriteLine($"{noType} + {toBox} = {sum}");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            int? z = null;
            if (z.HasValue)
                Console.WriteLine($"Has value = {z.Value}");
            else
                Console.WriteLine("Hasn't value");
            z = 12;
            if (z.HasValue)
                Console.WriteLine($"Has value = {z.Value}");
            else
                Console.WriteLine("Hasn't value");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            //----------------------------------------------------------------------------
            Console.WriteLine("---------Строки---------");
            string S1 = "little string";
            string S2 = "big string";
            if (S1.Equals(S2))
                Console.WriteLine("S1({0}) == S2({1})\n", S1, S2);
            else
                Console.WriteLine("S1({0}) != S2({1})\n", S1, S2);
            S2 = "little string";
            if (S1.Equals(S2))
                Console.WriteLine("S1({0}) == S2({1})", S1, S2);
            else
                Console.WriteLine("S1({0}) != S2({1})", S1, S2);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            string str1 = "Неполное пре";
            string str2 = "дложение полное";
            string str3 = "";
            //сцепление
            str1 = str1 + str2;
            Console.WriteLine(str1);
            //копирование
            str3 = str1;
            Console.WriteLine(str3);
            //выделение подстроки
            str3 = str3.Substring(9);
            Console.WriteLine(str3);
            //разделение подстроки на слова
            string[] WordsofStr = str1.Split(' ');
            Console.WriteLine($"{WordsofStr[0]} --- {WordsofStr[1]} --- {WordsofStr[2]}");
            //вставки подстроки в указанную позицию
            str1 = str1.Insert(str1.Length, WordsofStr[1]);
            Console.WriteLine(str1);
            //удаление заданной подстроки
            Console.Write("str2 = {0}", str2);
            str2 = str2.Remove(0, 9);
            Console.WriteLine(" ----> {0}", str2);
            string interpolation = "Провожу интерполяцию";
            Console.WriteLine($"{interpolation}");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            //интерполирование
            string emptyString = "";
            string nullString = null;
            if (string.IsNullOrEmpty(emptyString))
                Console.WriteLine("emptyString is empty");
            if (string.IsNullOrEmpty(nullString))
                Console.WriteLine("nullString is null");
            //что продемонстрировать?????
            StringBuilder buildString = new StringBuilder("AAAis is SPARTA");
            buildString.Remove(0, 3);
            buildString.Insert(0, "Th");
            int length = buildString.Length;
            buildString.AppendFormat("!!!");
            Console.WriteLine(buildString);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            Console.WriteLine("---------Массивы---------");
            int[,] twoArr = { { 1, 2, 3 }, { 4, 5, 6 },{ 7, 8, 9 } };
            int rows = twoArr.GetUpperBound(0) + 1;
            int columns = twoArr.GetUpperBound(1) + 1;
            for (int i = 0; i <rows;i++)
            {
                for(int j=0;j<columns; j++)
                    Console.Write($"{twoArr[i,j]} \t");
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            string[] strArr = { "It's ", "a", " part ", "of", " string\n" };
            foreach(string strPart in strArr)
                Console.Write(strPart);
            Console.WriteLine("Длина = " + strArr.Length);
            Console.WriteLine("Введите номер строки, которую хотите изменить(только число)");
            int Number = Int32.Parse(Console.ReadLine())-1;
            Console.WriteLine("Введите строку на которую нужно заменить");
            strArr[Number] = Console.ReadLine();
            foreach (string strPart in strArr)
                Console.Write(strPart);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            float[][] sharpArr = new float[3][];
            //for (int i = 0; i < sharpArr.Length; i++)
            //{
            //    Console.WriteLine("Введите размер массива");
            //    int size = Int32.Parse(Console.ReadLine());
            //    sharpArr[i] = new float[size];
            //}
            //Console.WriteLine("Заполни эти массивы");
            //for(int i = 0;i<sharpArr.Length;i++)
            //{
            //    Console.WriteLine("Массив номер {0}",i+1);
            //    for(int j=0;j<sharpArr[i].Length;j++)
            //        sharpArr[i][j] = Int32.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < sharpArr.Length;i++)
            //{
            //    Console.WriteLine("Массив номер {0}",i+1);
            //    for (int j = 0; j < sharpArr[i].Length; j++)
            //        Console.Write($"{sharpArr[i][j]}\t");
            //    Console.WriteLine();
            //}
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            string strvar = "String but var";
            var itsstr = strvar;
            Console.WriteLine(strvar);
            int[] arr = { 0, 5, 7, 19 };
            var arrInt = arr;
            Console.WriteLine("Arr but var");
            foreach (int partArr in arrInt)
            {
                Console.Write("{0}\t",partArr);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            Console.WriteLine("---------Кортежи---------");
            (int,string,char,string,ulong)cortege = (5, "string", 'c',"second string",4564815684615486555);
            Console.WriteLine("Все элемента кортежа: "+cortege);
            Console.WriteLine("Первый: "+ cortege.Item1);
            Console.WriteLine("Третий: " + cortege.Item3);
            Console.WriteLine("Четвертый: " + cortege.Item4);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            int intCortege = cortege.Item1;
            string stringCortege = cortege.Item2;
            char charCortege = cortege.Item3;
            ulong ulongCortege = cortege.Item5;
            (int Numb, string strOfCortege,_,_,_) = cortege;
            Console.WriteLine("cort = {0}\nNumb = {1}, strOfCortege = {2}",cortege,Numb,strOfCortege);
            (int, string, char, string, ulong) cortegeToCompare = (17, "string2", 'h', "second string", 4564815684615486555);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            if (cortege.Equals(cortegeToCompare))
                Console.WriteLine("cortege и cortegeToCompare равны");
            else
                Console.WriteLine("Не равны");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            Console.WriteLine("---------Возврат кортежа---------");
            (int,int,int,char) function(int[] argArr, string argStr)
            {
                return (argArr.Max(), argArr.Min(), argArr.Sum(), argStr.First());
            }
            int[] argumentArr = { 1, 2, 3, 4, 5 };
            string argumentStr = "F press F to pay respect";
            var cort = function(argumentArr,argumentStr);
            Console.WriteLine($"{argumentStr}\nargumentArr: ");
            foreach (int element in argumentArr)
                Console.Write("{0}\t",element);
            Console.WriteLine($"\nMax = {cort.Item1}\nMin = {cort.Item2}\nSum = {cort.Item3}\nFirst = {cort.Item4}");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            Console.WriteLine("---------checked/unchecked---------");
            Console.WriteLine("Checked "+ForChecked());
            Console.WriteLine("Unchecked "+ForUnchecked());
            Console.Read();
        }
    }
}
