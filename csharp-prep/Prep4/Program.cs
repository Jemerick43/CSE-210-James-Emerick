using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        Boolean running = true; //JE
        Console.WriteLine("Please enter a series of numbers. Program will continue upon entry of '0': ");
        while (running)
        {
            string number = Console.ReadLine();
            if (number == "0")
            {
                running = false; //JE
            }
            else
            {
                numberList.Add(int.Parse(number)); //JE
            }
        }

        int total = 0;  //JE
        float avg = 0;        //JE
        int max = 0;    //JE
        foreach (int number in numberList)

        {
            total = number + total; //JE
            avg = total / numberList.Count; //JE
            if (number > max)
            {
                max = number; //JE
            }
        }

        Console.WriteLine("The sum is: {0} \nThe average is: {1} \nThe largest number is: {2}", total, avg, max);

    }
}