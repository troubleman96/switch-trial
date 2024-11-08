using System;

class Program{
    static void Main (string [] arg){
    Console.WriteLine("Enter any number form 1-7: ");
    int myNo = Convert.ToInt32(Console.ReadLine());

    switch(myNo){
        case 1:
        System.Console.WriteLine("Monday");
        break;

        case 2:
        System.Console.WriteLine("tuesday");
        break;

        case 3:
        Console.WriteLine("wednseday");
        break;

        case 4:
        Console.WriteLine("Thursday");
        break;

        case 5:
        Console.WriteLine("Friday");
        break;

        case 6:
        Console.WriteLine("saturday");
        break;

        case 7:
        Console.WriteLine("sunday");
        break;    }
    }
}
