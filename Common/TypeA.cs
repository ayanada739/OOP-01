using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;



namespace Common
{
    // TypeA Accessible Within its Project and Within External Project [Import]
    public class TypeA
    {
        // What You Can Write Inside The Struct Or Class
        //1.Attributes [Fields] >>Member Variable
        //2.Functions [Constructor, Getter Setter, Method]
        //3.Properties [Full Property, Automatic Property , Indexer]
        //4.Events


        //Access Modifier Allowed Inside Class?
        //1.Private [Default]
        //2.Private Protected
        //3.Protected
        //4.Internal
        //5.Protected Internal
        //6.Pub1ic

        //Access Modifier Allowed Inside Struct?
        //1.Private [Default]
        //2.Internal
        //3.Public

       //private int X; // Accessible Within Its Scope ONLY
       //internal int Y; //Accessible Within Its Scope And Its Project
       //public int Z;// Accessible Within Its Sco e And Pro •ect

        //void Print()
        //{
        //    Console.WriteLine(X);
        //}






        //public TypeA()
        //{
        //    TypeB obj = new TypeB(); //Valid


        //}

    }
}
