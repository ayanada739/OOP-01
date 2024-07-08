using System;


namespace Assignments
{


    #region 1.	Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

    //    enum WeekDays
    //    {
    //       Monday,
    //       Tuesday,
    //       Wednesday,
    //       Thursday,
    //       Friday,
    //       Saturday,
    //       Sunday
    //    }

    //class Program
    //{
    //    static void Main()
    //    {
    //        foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
    //        {
    //            Console.WriteLine(day);
    //        }
    //    }
    //}
    #endregion

    #region 2.  Create an enum called "Season" with the four seasons(Spring, Summer, Autumn, Winter) as its members.Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

    //enum Season
    //{
    //    Spring,
    //    Summer,
    //    Autumn,
    //    Winter
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
    //        string input = Console.ReadLine();

    //        if (Enum.TryParse(input, true, out Season season))
    //        {
    //            switch (season)
    //            {
    //                case Season.Spring:
    //                    Console.WriteLine("March to May");
    //                    break;
    //                case Season.Summer:
    //                    Console.WriteLine("June to August");
    //                    break;
    //                case Season.Autumn:
    //                    Console.WriteLine("September to November");
    //                    break;
    //                case Season.Winter:
    //                    Console.WriteLine("December to February");
    //                    break;
    //            }
    //        }
    //        else
    //        {
    //            Console.WriteLine("Invalid season entered.");
    //        }
    //    }
    //}

    #endregion

    #region 3.  Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum. ⮚  Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable

    //[Flags]
    //enum Permissions
    //{
    //    None = 0,
    //    Read = 1,
    //    Write = 2,
    //    Delete = 4,
    //    Execute = 8
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Permissions userPermissions = Permissions.Read | Permissions.Write;
    //        Console.WriteLine("Initial Permissions: " + userPermissions);

    //        userPermissions |= Permissions.Execute;
    //        Console.WriteLine("After adding Execute: " + userPermissions);

    //        userPermissions &= ~Permissions.Write;
    //        Console.WriteLine("After removing Write: " + userPermissions);

    //        bool hasDelete = (userPermissions & Permissions.Delete) == Permissions.Delete;
    //        Console.WriteLine("Has Delete Permission: " + hasDelete);
    //    }
    //}
    #endregion

    #region 4.  Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

    //enum Colors
    //{
    //    Red,
    //    Green,
    //    Blue
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Console.WriteLine("Enter a color (Red, Green, Blue):");
    //        string input = Console.ReadLine();

    //        if (Enum.TryParse(input, true, out Colors color))
    //        {
    //            Console.WriteLine($"{color} is a primary color.");
    //        }
    //        else
    //        {
    //            Console.WriteLine($"{input} is not a primary color.");
    //        }
    //    }
    //}
    #endregion

    #region 5.  Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

    //struct Point
    //{
    //    public double X { get; set; }
    //    public double Y { get; set; }

    //    public Point(double x, double y)
    //    {
    //        X = x;
    //        Y = y;
    //    }

    //    public double DistanceTo(Point other)
    //    {
    //        double dx = X - other.X;
    //        double dy = Y - other.Y;
    //        return Math.Sqrt(dx * dx + dy * dy);
    //    }
    //}
    
    //class Program
    //{
    //    static void Main()
    //    {
    //        Console.WriteLine("Enter coordinates for Point 1 (x y):");
    //        string[] point1Input = Console.ReadLine().Split();
    //        Point point1 = new Point(double.Parse(point1Input[0]), double.Parse(point1Input[1]));

    //        Console.WriteLine("Enter coordinates for Point 2 (x y):");
    //        string[] point2Input = Console.ReadLine().Split();
    //        Point point2 = new Point(double.Parse(point2Input[0]), double.Parse(point2Input[1]));

    //        double distance = point1.DistanceTo(point2);
    //        Console.WriteLine($"Distance between points: {distance}");
    //    }
    //}
    #endregion




}

