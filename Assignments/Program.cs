﻿using System;


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




}

