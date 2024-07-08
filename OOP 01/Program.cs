using System;
using System.ComponentModel;
using Common;
namespace OOP_01
{

    //What You Can Write Inside Namespace???
    //   1.Class
    //   2.Struct
    //   3.Interface
    //   4.Enum

    // Access Modifier Allowed Inside Namespace
    // 1. Internal [default]
    // 2. Public

    internal class Program
    {
        #region Exception Handling
        static void DoSomeCode()
        {
            try
            {
                int X, Y, Z;
                X = int.Parse(Console.ReadLine());  // System. FormatException
                Y = int.Parse(Console.ReadLine());
                Z = X / Y; // System. DivideByZeroException

                int[] Numbers = { 1, 2, 3 }; // Size = 3
                Numbers[10] = 100; // System. IndexOutOfRangeException
            }
            // If Any Exception Happened In Try Block
            // CLR Will create Object From Class Of Exception
            // Through In Catch Block
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void DoSomeProtectiveCode()
        {

            int X, Y, Z;
            bool Flag;
            do
            {
                Console.WriteLine("Enter First Number");
                Flag = int.TryParse(Console.ReadLine(), out X);
            } while (!Flag);

            do
            {
                Console.WriteLine("Enter Second Number");
                Flag = int.TryParse(Console.ReadLine(), out Y);

            } while (!Flag || Y == 0);

            Z = X / Y;// System. DivideByZeroException

            int[] Numbers = null;// System . NullReferenceException
            if (Numbers?.Length > 10)
            {
                // Numbers= null=> Numbers? . Length = Null
                // Numbers! =null=> Numbers? . Length = Length
                Numbers[10] = 100;
            }

        }

        #endregion

        #region MyRegion

        #endregion

        static void Main(string[] args)
        {
            #region Exception Handling

            //DoSomeCode(); //Runtime Errors [Exceptions]

            // Exception
            //1.System Exceptions
            //  i. 1 Format Exception
            //  1.2 Index Out Of Range Exception
            //  1.3 Null Reference Exception
            //  1.4 Invalid Operation Exception
            //  1.5 Arithmetic Exceptionl
            //     1.5.1 Divided Zero Exception
            //     1.5.2 Overflow Exception
            //2.Application Exception

            //try
            //{
            //    DoSomeProtectiveCode();
            //    throw new Exception();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            // Close | Delete | Release | Deallocate Unmanaged Resources
            // Open File
            // Connection With Database
            //        Console.WriteLine("finally");
            //    }

            //    Console.WriteLine("After Try Catch");


            #endregion

            #region Access Modifiers

            //TypeA obj = new TypeA(); //Valid

            //TypeB obj2 = new Common.TypeB(); // Invalid [Internal] 
            // 'TypeB' is inaccessible due to its protection

            //obj.X = 10; //INVALID >>'TypeA.X' is inaccessible due to its protection levet
                        // X is Private

            //obj.Y = 20; // Invalid
            //Y is internal

            //obj.Z = 30; // Valid
            //Z is Public
            #endregion

        }
    }
}
