﻿using PersonData;
using PersonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp;

internal class DatasetMethods
{
    public void main()
    {
        var dataset = DatasetAccess.LoadData(@"C:\Users\Virtualpro\source\repos\CNET2-SARA\data2024.json");

        var context = new PeopleContext();

        var cnt = context.People.Count();

        Console.WriteLine($"people cnt: {cnt}");

        Console.WriteLine("Naplnit db? (y/n)");
        var answer = Console.ReadLine();
        if (answer.ToLower() == "y")
        {
            context.People.AddRange(dataset);
            context.SaveChanges();
            Console.WriteLine("done");
        }
        else
        {
            Console.WriteLine("skipping");
        }
    }
}
