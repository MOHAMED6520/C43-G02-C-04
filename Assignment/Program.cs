namespace Assignment
{
    internal class Program
    {
       
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

        }
    }
}
