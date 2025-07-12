namespace Assignment
{
    internal class Program
    {
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

        static void Main(string[] args)
        {
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



        }
    }
}
