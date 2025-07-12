namespace Assignment
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
        }
    }
}
