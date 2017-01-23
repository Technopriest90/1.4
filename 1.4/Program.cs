using System;
     //  class c4_1 // Продемонстрировать работу оператора %
     //   {
     //       static void Main()
     //       {
     //       int iresult, irem;
     //       double dresult, drem;
     //
     //       iresult = 10 / 3;
     //       irem = 10 % 3;
     //
     //       dresult = 10.0 / 3.0;
     //       drem = 10.0 % 3.0;
     //
     //       Console.WriteLine("Результат и остаток от деления 10/3: " + iresult + " " + irem);
     //       Console.WriteLine("Результат и остаток от деления 10.0 / 3.0: " + dresult + " " + drem);
     //       Console.ReadKey();
     //
     //
     //       }
     //   }

   // class c4_2  // декремент и инкремент
   // {
   // static void Main()
   // {
   //     int x, y;
   //     int i;
   //
   //     x = 1;
   //     y = 0;
   //     Console.WriteLine("Ряд чисел, полученных " + "с помощью оператора y=y+x++");
   //     for(i=0;i<10;i++)
   //     {
   //         y = y + x++; //постфиксная форма оператора ++
   //
   //         Console.WriteLine(y + " ");
   //     }
   //     Console.WriteLine();
   //
   //     x = 1;
   //     y = 0;
   //     Console.WriteLine("Ряд чисел, полученных " + "с помощью оператора y=y+ ++x;");
   //     for(i=0;i<10; i++)
   //     {
   //         y = y + ++x; //префиксная форма оператора ++
   //
   //         Console.WriteLine(y + "");
   //     }
   //     Console.WriteLine();
   //     Console.ReadKey();
   // }
   // }

    //   class MakeEven    // Применить подразрядный оператор И, чтобы сделать число четным.
    //{
    //    static void Main()
    //    {
    //        ushort num;
    //        ushort i;
    //
    //        for (i=1;i<=10;i++)
    //        {
    //            num = i;
    //
    //            Console.WriteLine("num: " + num);
    //
    //            num = (ushort)(num & 0xFFFE);
    //
    //            Console.WriteLine("num после сброса младшего разряда: " + num + "\n");
    //
    //        }
    //        Console.ReadKey();
    //    }
    //} 
    //    class IsOdd //применить подразрядный оператора И, чтобы определить, является ли число нечетным
    //{
    //    static void Main ()
    //    {
    //        ushort num;
    //
    //        num = 10;
    //
    //        if ((num & 1) == 1)
    //            Console.WriteLine("Не выводится.");
    //
    //        num = 11;
    //
    //        if ((num & 1) == 1)
    //            Console.WriteLine(num +" - нечетное число.");
    //
    //        Console.ReadKey();
    //    }
    //}
    //     class ShowBits // Показать биты, составляющие байт.
    // {
    //     static void Main()
    //     {
    //         int t;
    //         byte val;
    // 
    //         val = 123;
    //         for (t=128;t>0;t=t/2)
    //         {
    //             if ((val & t) != 0) Console.Write("1 ");
    //             if ((val & t) == 0) Console.Write("0 ");
    //         }
    //         Console.ReadKey();
    //     }
    // }
     
    //    class MakeOdd // применить подразрядный оператор ИЛИ, чтобы сделать число нечетным.
    //{
    //    static void Main()
    //    {
    //        ushort num;
    //        ushort i;
    //
    //        for (i=1; i<=10; i++)
    //        {
    //            num = i;
    //
    //            Console.WriteLine("num: " + num);
    //
    //            num = (ushort)(num | 1);
    //
    //            Console.WriteLine("num после установки младшего разряда: " + num + "\n");
    //
    //        }
    //        Console.ReadKey();
    //    }
    //}
    //    class Encode  //продемонстрировать применение подразрядного оператора исключающее ИЛИ.
    //{
    //    static void Main()
    //    {
    //        char ch1 = 'H';
    //        char ch2 = 'i';
    //        char ch3 = '!';
    //
    //        int key = 88;
    //
    //        Console.WriteLine("Исходное сообщение: " + ch1 + ch2 + ch3);
    //
    //        //зашифровать сообщение.
    //        ch1 = (char)(ch1 ^ key);
    //        ch2 = (char)(ch2 ^ key);
    //        ch3 = (char)(ch3 ^ key);
    //
    //        Console.WriteLine("Зашифрованное сообщение: " + ch1 + ch2 + ch3);
    //
    //        //расшифровать сообщение.
    //        ch1 = (char)(ch1 ^ key);
    //        ch2 = (char)(ch2 ^ key);
    //        ch3 = (char)(ch3 ^ key);
    //
    //        Console.WriteLine("Расшифрованное сообщение: " + ch1 + ch2 + ch3);
    //
    //        Console.ReadKey();
    //    }
    //}

    //     class NotDemo //Продемонстрировать применение подразрядного унарного оператора НЕ.
    // {
    //     static void Main()
    //     {
    //         sbyte b = -34;
    //         for(int t=128; t>0; t=t/2)
    //         {
    //             if ((b & t) != 0) Console.Write("1 ");
    //             if ((b & t) == 0) Console.Write("0 ");
    //         }
    // 
    //         Console.WriteLine();
    // 
    //         // обратить все биты
    //         b = (sbyte)~b;
    //         for(int t= 128; t>0; t=t/2)
    //         {
    //             if ((b & t) != 0) Console.Write("1 ");
    //             if ((b & t) == 0) Console.Write("0 ");
    //         }
    //         Console.ReadKey();
    //     }
    // }

    //    class ShiftDemo // Продемонстрировать применение операторов сдвига.
    //{
    //    static void Main()
    //    {
    //        int val = 1;
    //
    //        for(int i = 0; i<8;i++)
    //        {
    //            for(int t=128;t>0;t=t/2)
    //            {
    //                if ((val & t) != 0) Console.Write("1 ");
    //                if ((val & t) == 0) Console.Write("0 ");
    //            }
    //            Console.WriteLine();
    //            val = val << 1; //сдвиг влево
    //        }
    //
    //        val = 128;
    //
    //        for (int i = 0; i < 8; i++)
    //        {
    //            for (int t = 128; t > 0; t = t / 2)
    //            {
    //                if ((val & t) != 0) Console.Write("1 ");
    //                if ((val & t) == 0) Console.Write("0 ");
    //            }
    //            Console.WriteLine();
    //            val = val >> 1; //сдвиг вправо
    //        }
    //        Console.ReadKey();
    //    }
    //}
    //    class MultDiv //применить операторы сдвига для умножения и деления на 2
    //{
    //    static void Main()
    //    {
    //        int n;
    //
    //        n = 10;
    //
    //        Console.WriteLine("Значение переменной n: " + n);
    //
    //        //умножить на 2.
    //        n = n << 1;
    //        Console.WriteLine("Значение переменной n после " + "операции n = n * 2: " + n);
    //
    //        //умножить на 4.
    //        n = n << 2;
    //        Console.WriteLine("Значение переменной n после " + "операции n = n * 4: " + n);
    //
    //        //разделить на 2.
    //        n = n >> 1;
    //        Console.WriteLine("Значение переменной n после " + "операции n = n / 2: " + n);
    //
    //        //разделить на 4.
    //        n = n >> 2;
    //        Console.WriteLine("Значение переменной n после " + "операции n = n / 4: " + n);
    //        Console.WriteLine();
    //
    //        //установить пременную n в исходное состояние.
    //        n = 10;
    //        Console.WriteLine("Значение переменной n: " + n);
    //        //умножить на 2 тридцать раз.
    //        n = n << 30; //данные теряются
    //        Console.WriteLine("Значение переменной n после " + "сдвига на 30 позиций влево: " + n);
    //        Console.ReadKey();
    //
    //            }
    //}

    //     class NoZeroDiv
    // {
    //     static void Main()
    //     {
    //         int result;
    // 
    //         for (int i = -5; i < 6; i++)
    //         {
    //             result = i != 0 ? 100 / i : 0;
    //             if (i != 0)
    //                 Console.WriteLine("100 / " + i + " равно " + result);
    //         }
    //         Console.ReadKey();
    //     }
    // }
    // 
    //     class NoZeroDiv2 // разделить только на четные, Ненулевые значения.
    // {
    //     static void Main()
    //     {
    //         for (int i = -5; i < 6; i++)
    //             if (i != 0 ? (i % 2 == 0) : false)
    //                 Console.WriteLine("100 / " + i + " равно " + 100 / i);
    //         Console.ReadKey();
    //     }
    // }