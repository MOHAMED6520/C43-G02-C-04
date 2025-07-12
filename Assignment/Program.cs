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

        }
    }
}
