using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DemoExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LINQ");
            //LinqExample.Demo();
            //LinqToEntities.Entities();
            //LinqToEntitiesUsingJoins.EntitiesUsingJoin();
            LinqToDataTable linqToDataTable = new LinqToDataTable();
            linqToDataTable.AddDataTable();
        }
    }
}
