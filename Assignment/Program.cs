﻿namespace Assignment
{
    internal class Program
    {
        //static void PrintShape()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine("^-^");
        //    }
        //}

        //static void PrintShape(int Count)    
        //{
        //    for (int i = 0; i < Count; i++)
        //    {
        //        Console.WriteLine("^-^");
        //    }
        //}

        //static void PrintShape(  string Patern  = "******", int Count = 3)
        //{
        //    for (int i = 0; i < Count; i++)
        //    {
        //        Console.WriteLine(Patern);
        //    }
        //}

        //static int SumNumber (int Num1,int Num2)
        //{
        //    return Num1 + Num2;
        //}

        //static void SWAP(int x, int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}

        //static void SWAP(ref int x,ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}

        //static int SumArray(int[] array)
        //{
        //    int sum = 0;
        //    array[0] = 100;
        //    for (int i = 0; i < array.Length; i++) 
        //        sum += array[i];
        //    return sum;
        //}
        //static int SumArray(ref int[] array)
        //{
        //    int sum = 0;
        //    array[0] = 100;
        //    for (int i = 0; i < array.Length; i++)
        //        sum += array[i];
        //    return sum;
        //}

        //static int SumArray(int[] array)
        //{
        //    int sum = 0;
        //    array = new int[] { 4,5,3,2};
        //    for (int i = 0; i < array.Length; i++)
        //        sum += array[i];
        //    return sum;
        //}

        //static int SumArray( ref int[]  array)
        //{
        //    int sum = 0;
        //    array = new int[] { 4, 5, 3, 2 };
        //    for (int i = 0; i < array.Length; i++)
        //        sum += array[i];
        //    return sum;
        //}
        //static int [] SumMul (int A , int B)
        //{
        //    int[] SumMul = { A + B, A * B };
        //    return SumMul ;
        //}

        //static int[] SumMul(int A, int B)
        //{
        //    int[] SumMul = { A + B, A * B };
        //    return SumMul;
        //}
        //static NewData SumMul(int A, int B)
        //{
        //   NewData data = new NewData();
        //    data.Sum = A+B;
        //    data.Mul = A*B;
        //    return data;
        //}    

        //static void SumMul(int A, int B,out int Sum , out int Mul)
        //{
        //  Sum = A + B;
        //  Mul = A * B;
        //}

        //static int SumArray(params int[] Arr)
        //{ 
        //    int sum = 0;    
        //for (int i = 0; i < Arr.Length; i++) 
        //        sum += Arr[i];
        //        return sum;
        //}
        <<<<<<< Assignment1
        #region Q01
        //static int ValueMultipliedByFiveByValue(int value)
        //{
        //    value *= 5;
        //    return value;
        //}

        //static int ValueMultipliedByFiveByReferences(ref int value)
        //{
        //    value *= 5;
        //    return value;
        //} 
        #endregion

        #region Q02
        //static string PrintStringAfterModifyByValue (string text)
        //{
        //    text += " Mohamed";
        //    return text;
        //}

        //static string PrintStringAfterModifyByReference(ref string text)
        //{
        //    text += " Mohamed";
        //    return text;
        //} 
        #endregion

        #region Q03
        //static void SumMul (int X , int Y, out int Sum , out int Mul)
        //{
        //    Sum = X+Y;
        //    Mul = X*Y;
        //} 
        #endregion

        #region Q04
        //static void SumDigit (int Number)
        //{
        //    int sum = 0,num=Number;

        //  while (num > 0)
        //    {
        //        sum+= num % 10;
        //        num /= 10;
        //    }
        //    Console.WriteLine($"The sum of the digits of the number {Number} is: {sum} ");

        //} 
        #endregion

        #region Q05
        //static void IsPrimewithvoid(int n)
        //{
        //    int counter = 0;
        //    for (int i = 2; i <= n / 2; i++)
        //    {
        //        if (n % i == 0)
        //            break;
        //        else
        //            counter++;

        //    }

        //    if (counter == (n / 2) - 1)
        //        Console.WriteLine("prime");
        //    else
        //        Console.WriteLine("Not Prime");
        //}
        ////---------
        //static bool IsPrimewithbool(int n)
        //{
        //    bool result = false;
        //    int counter = 0;
        //    for (int i = 2; i <= n / 2; i++)
        //    {
        //        if (n % i == 0)
        //            break;
        //        else
        //            counter++;

        //    }

        //    if (counter == (n / 2) - 1)
        //        result = true;
        //    return result;
        //}
        #endregion

        #region Q06
        //static void MinMaxArray (ref int[]r)
        //{
        //    int min = r[0];
        //    int max = r[0];
        //  for (int i = 0; i < r.Length; i++)
        //    {
        //        if (min > r[i])
        //            min = r[i];
        //        if (max < r[i])
        //            max = r[i];
        //    }
        //    Console.WriteLine($"The Min Number In Array : {min}");
        //    Console.WriteLine($"The max Number In Array : {max}");
        //}
        ////-----------------------
        //static int[] MinMaxArrayWithreturn(ref int[] r)
        //{

        //    int min = r[0];
        //    int max = r[0];
        //    for (int i = 0; i < r.Length; i++)
        //    {
        //        if (min > r[i])
        //            min = r[i];
        //        if (max < r[i])
        //            max = r[i];
        //    }
        //    r[0] = min;
        //    r[1] = max;
        //    return r;
        //} 
        #endregion

        #region Q07
        //static int factorial(int n)
        //{
        //    if (n == 1)
        //        return 1;

        //    return n * factorial(n-1);

        //} 
        #endregion

        #region  Q08
        //static string ChangeChar ( ref string Name , char c , int p)
        //{
        //    string ns=null ;
        //    for (int i = 0;i<Name.Length;i++)
        //    {
        //        if (i == p)
        //            ns += c;
        //        else
        //            ns += Name[i];


        //    }
        //    Name = ns ;
        //    return Name;   
        //} 
        #endregion
        static void Main(string[] args)
        {
            #region One_D_Array
            //int[] Numbers;
            //Declare for reference (pointer) from type 'Array of integer'

            //Numbers = new int[5];
            //Allocate the number of required bytes for the object at HEAP

            //Console.WriteLine(Numbers[0]);
            //Console.WriteLine(Numbers[1]);

            //Numbers[0] = 1;
            //Numbers[1] = 2;
            //Numbers[2] = 3;
            //Numbers[3] = 4;
            //Numbers[4] = 5;
            //  Numbers[5] = 6; //Invalid Out of range

            //Console.WriteLine(Numbers[0]);
            //Console.WriteLine(Numbers[1]);
            //Console.WriteLine(Numbers[2]);
            //Console.WriteLine(Numbers[3]);
            //Console.WriteLine(Numbers[4]);

            //int [] Number01= {1,2,3,4,5};
            //int[] Number02 = new int[5] { 1, 2, 3, 4, 5 };
            //int[] Number03 = new int[] {1,2, 3, 4,5};

            //int[] Numbers = new int[5];
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.Write($"Enter Number Of [{i}] : ");
            //    Numbers[i] = int.Parse( Console.ReadLine() );
            //}
            //Console.WriteLine("===================");
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.Write($"{Numbers[i]} ");

            //}

            //Console.WriteLine(Numbers.Length);
            //Console.WriteLine(Numbers.Rank); 
            #endregion

            #region Two D Array
            ////Two D Array

            //int[,] Marks = new int[3,3];
            ////Marks[0,0] = 99;
            ////Marks[0, 1] = 52;
            ////Marks[0, 2] = 98;
            ////Marks[1, 0] = 7;
            ////Marks[1, 1] = 58;
            ////Marks[1, 2] = 98;

            ////Console.WriteLine(Marks[0,0]);
            ////Console.WriteLine(Marks[0,1]);
            ////Console.WriteLine(Marks[0,2]);
            ////Console.WriteLine(Marks[1,0]);
            ////Console.WriteLine(Marks[1,1]);
            ////Console.WriteLine(Marks[1,2]);

            ////for (int i = 0; i < 3; i++)
            ////{
            ////    for(int j = 0; j < 3; j++)
            ////    {
            ////        Console.Write($"Enter Of Mark [{i},{j}] :  ");
            ////        Marks[i,j] = int.Parse( Console.ReadLine() );
            ////    }
            ////}

            ////for (int i = 0; i < 3; i++)
            ////{
            ////    for (int j = 0; j < 3; j++)
            ////    {
            ////        Console.Write($"{Marks[i,j]} ");

            ////    }
            ////    Console.WriteLine();
            ////}
            ////int x=0, y=0;
            ////for (int i = 0;i<Marks.Length; i++)
            ////{
            ////    if (y == 3)
            ////    {
            ////        x++;
            ////        y = 0;
            ////        Console.WriteLine();
            ////    }
            ////    Console.Write($"{Marks[x, y]} ");
            ////    y++;

            ////} 
            #endregion

            #region Two D Array Juddge
            //int[][] Marks = new int[3][];
            //Marks[0] = new int[] { 1,2,3};
            //Marks[1] = new int[] {1};
            //Marks[2] = new int[] { 1, 2, 3 ,4 };

            //for (int i = 0;i<3;i++)
            //{
            //    for (int j = 0;j<Marks[i].Length;j++)

            //    {
            //        Console.Write($"Marks[{i}][{j}] : ");
            //        Marks[i][j]=int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < Marks[i].Length; j++)

            //    {
            //        Console.Write($"{Marks[i][j]} ");

            //    }
            //} 
            #endregion

            #region Function Prototype
            // Function : Block Of Code 
            // PrintShape();

            // PrintShape(5);

            //PrintShape(5, "*******");
            //PrintShape(Patern:"*****",Count:3);

            //int sum = SumNumber(5, 2);
            // Console.WriteLine(SumNumber(5, 2)); 
            #endregion

            #region Passing Parameter Value Type

            //Passing By Value


            //int A = 4 , B = 5 ;

            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");

            //Console.WriteLine("-------- After Swap ---------");
            //SWAP( A , B);
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");

            //Passing By Reference
            //int A = 4 , B = 5 ;
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");

            //Console.WriteLine("-------- After Swap ---------");
            //SWAP(ref A, ref B);
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}"); 
            #endregion

            #region Passing Parameter Reference Type
            // Passing Parameter Reference Type

            // Passing By Value 

            //int [] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(Numbers));
            //Console.WriteLine(Numbers[0]);




            //Passing By Reference
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(ref Numbers));
            //Console.WriteLine(Numbers[0]); 

            // example 02
            //Passing Parameter Reference Type

            // Passing By Value

            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(Numbers));
            //Console.WriteLine(Numbers[0]);


            // Passing By References


            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(ref Numbers));
            //Console.WriteLine(Numbers[0]);

            #endregion

            #region Passing By Out

            // int x=3 , y=5 ;
            //int []arr= SumMul (x , y );
            // Console.WriteLine(arr[0]);
            // Console.WriteLine(arr[1]);

            //  int x=3 , y=5 ;
            // NewData data = new NewData();
            //data = SumMul(x,y);
            // Console.WriteLine(data.Sum);
            // Console.WriteLine(data.Mul);

            //int A = 5, B = 4, Mul, Sum;
            //SumMul (A, B,out Sum,out Mul);

            //Console.WriteLine(Sum);
            //Console.WriteLine(Mul); 
            #endregion

            #region Params
            //Params
            //int [] Numbers = { 1, 2, 3, 4 };
            //Console.WriteLine(SumArray(1,2,4,5,7,8)); 
            #endregion
                 #region Q01
            /*
                  At passing by value means make copy of actual parameter value at stack
                  and if the values of the parameters at the function are changed
                  the actual value will not be affected.

                  At passing by Reference means  making a copy of the actual parameter's
                  alias or reference which points to the same space in stack
                  and if the values of the parameters at the function are changed
                  the actual value will change.
                */

            //Passing By Value

            //int x = 3;
            //Console.WriteLine("Passing By Value");
            //Console.WriteLine($"x = {x}");
            //Console.WriteLine("After Multiply ");
            //ValueMultipliedByFiveByValue(x);
            //Console.WriteLine($"x = {x}");
            //Console.WriteLine();
            ////Passing By references
            //Console.WriteLine();
            //Console.WriteLine("Passing By references");
            //Console.WriteLine($"x = {x}");
            //Console.WriteLine("After Multiply ");
            //ValueMultipliedByFiveByReferences(ref x);
            //Console.WriteLine($"x = {x}"); 
            #endregion

            #region Q02
            //static string PrintStringAfterModifyByValue (string text)
            //{
            //    text += " Mohamed";
            //    return text;
            //}

            //static string PrintStringAfterModifyByReference(ref string text)
            //{
            //    text += " Mohamed";
            //    return text;
            //} 
            #endregion

            #region  Q03
            //int X = 5;
            //int Y = 10;
            //SumMul (X , Y, out int sum,out int mul);
            //Console.WriteLine($"{X} + {Y} = {sum}");
            //Console.WriteLine($"{X} * {Y} = {mul}"); 
            #endregion

            #region Q04
            //    Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //    SumDigit(number); 
            #endregion

            #region Q05
            //IsPrimewithvoid(7);

            ////-------
            //bool result = IsPrimewithbool(7);
            //Console.WriteLine(result); 
            #endregion

            #region Q06
            // int[] r = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //MinMaxArray(ref r);
            //--------------------------

            //MinMaxArrayWithreturn(ref r);
            //Console.WriteLine(r[0]);
            //Console.WriteLine(r[1]); 
            #endregion

            #region Q07
            // Console.WriteLine(factorial(4)); 
            #endregion

            #region Q08
            //string Name = "mohamed";
            //ChangeChar(ref Name, 'a', 1);
            //Console.WriteLine(Name); 
            #endregion

            #region Q09

            //Console.Write("Enter The Value Of N : ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //        Console.Write(n);
            //    Console.WriteLine();
            //} 
            #endregion

            #region Q10
            //int sum = 0;
            //int[] arr = { 14, 22, 31, 45, 50 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];

            //}
            //Console.WriteLine(sum); 
            #endregion

            #region Q11
            // int[] arr1 = { 14, 22, 31, 45, 50 };
            // int[] arr2 = { 4, 12, 301, 75, 57 };
            // int[] result = new int[arr1.Length*2];

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    result[i] = arr1[i];

            //}
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    result[arr1.Length+i] = arr2[i];

            //}

            //Console.WriteLine("Array Befor Sort");
            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.Write($" {result[i]}");

            //}
            //Console.WriteLine();
            //int temp = 0;
            //for (int i = 0; i < result.Length; i++)
            //{

            //    for (int j = i; j < result.Length; j++)
            //    {
            //        if (result[i] > result[j])
            //        {
            //            temp=result[i];
            //            result[i]=result[j];
            //            result[j]=temp;
            //        }
            //    }
            //}

            //Console.WriteLine("Array After Sort");
            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.Write ($" {result[i]}"); 

            //} 
            #endregion

            #region Q12
            //int[] arr = { 11, 2, 23, 44, 15, 65, 74, 18, 90 };
            //int min = arr[0], max = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] < min)
            //        min = arr[i];
            //    if (arr[i] > max)
            //        max = arr[i];
            //}
            //Console.WriteLine($"Max = {max}");
            //Console.WriteLine($"Min = {min}"); 
            #endregion

            #region Q13
            //int[] arr = { 11, 2, 23, 44, 15, 65, 74, 18, 90 };
            //int max2 = arr[0], max = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{

            //    if (arr[i] > max)
            //    {
            //        max2 = max;
            //        max = arr[i];
            //    }

            //}
            //Console.WriteLine($"he second largest element = {max2}"); 
            #endregion

            #region Q14
            //Console.Write("Enter The lenth of Array : ");
            //int len = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter the values");
            //int []arr = new int[len];
            //for (int i = 0; i < len; i++)
            //    arr[i] = int.Parse(Console.ReadLine());

            //int dis = 0 ,lastdis=0;

            //for (int i =0;i<len;i++)
            //{
            //    for (int j = i; j < len; j++)
            //    {
            //        if (arr[i] == arr[j])
            //            dis = j - i-1;
            //    }
            //    if (lastdis<dis)
            //        lastdis = dis;
            //    dis = 0;
            //}

            //Console.WriteLine($"The longest distance between Two equal cells = {lastdis}");

            #endregion

            #region Q15
            //Console.Write("Enter String : ");

            //string word = Console.ReadLine();
            //string[] wordAfter = word.Split(' ');

            //for (int i = wordAfter.Length-1; i >= 0; i--)
            //{
            //    Console.Write($"{wordAfter[i]} ");
            //} 
            #endregion

            #region Q16
            //int [,]arr1 = new int[3,3];
            //int[,] arr2 = new int[3, 3];
            //Console.WriteLine("Enter the values ");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        arr1[i,j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        arr2[i, j] = arr1[i,j];
            //    }
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{arr2[i, j]} "); 
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #region Q17
            //int[]arr = { 1, 2, 31, 41 , 7, 8,84,11 };
            //Console.WriteLine("Array Befor Reverse");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i] } ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Array After Reverse");
            //for (int i = arr.Length-1; i >= 0; i--)
            //{
            //    Console.Write($"{arr[i]} ");
            //} 
            #endregion
        }
    }
}
