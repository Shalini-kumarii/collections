using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
    static void Main(string[] args)
        {
// --1 array holding 0 to 9 value----------
            int[] arrOfInt = {0,1,2,3,4,5,6,7,8,9};
            for( int i=0; i<arrOfInt.Length;i++)
            {
                Console.WriteLine("array number is:"+arrOfInt[i]);
            }

// 2 --Array names-------
            string[] names=new string[]{"Tim","Martin","Nikki","Sara"};
            for(int j=0; j<names.Length;j++)
            {
                Console.WriteLine($"Names are :{names[j]}");
            }

// 3 alternate true and false
        bool[] arr = new bool[10];
        arr[0] = true;
        arr[1] = false;
        arr[2] = true;
        arr[3] = false;
        arr[4] = true;
        arr[5] = false;
        arr[6] = true;
        arr[7] = false;
        arr[8] = true;
        arr[9] = false;
        foreach (bool result in arr)
         {
            Console.WriteLine(result);
        }

    
// 4 List icecream 
List<string> icecream = new List<string>();
//Use the Add function in a similar fashion to push
icecream.Add("Vanilla");
icecream.Add("Rosted almond");
icecream.Add("Strawberry");
icecream.Add("Coconut");
icecream.Add("Chocolate");

Console.WriteLine($"We have {icecream.Count} flavours");
Console.WriteLine(icecream[2]);
icecream.RemoveAt(2); 
Console.WriteLine(icecream[2]);
Console.WriteLine($"We have {icecream.Count} flavours");


//  5

Dictionary<string,string> profile = new Dictionary<string,string>();
//Almost all the methods that exists with Lists are the same with Dictionaries
Random rand=new Random();
for(int dict=0;dict<names.Length;dict++)
{
   string key=names[dict];
   string value=icecream[rand.Next(4)];
   profile.Add(key,value);
}
foreach (var entry in profile)
{
    Console.WriteLine(entry.Key + " - " + entry.Value);
}


        }
    }
}
