using System.Collections.Generic;
using System.Threading;

// *** LISTS 1 ***
//creating the list and adding the names in it:
List<string> nameList = new List<string>();
nameList.Add("Ahmet");
nameList.Add("Mehmet");
nameList.Add("Ali");
nameList.Add("Veli");
nameList.Add("Şakir");
nameList.Add("Abbas");
nameList.Add("Haydar");
nameList.Add("Abuzer");

// logging the names using for loop:
Console.WriteLine("*** Davetliler ***");
for (int i = 0; i < nameList.Count; i++)
{
    Console.WriteLine($"{i+1} - {nameList[i]}");
}

// *** LISTS 2 ***
List<string> coffeeList = new List<string>();
for (int i = 0;i < 5; i++)
{
    Console.WriteLine("kahvenizin ismini yazınız:");
    string coffee = Console.ReadLine();
    coffeeList.Add(coffee);
}
int num = 1;
foreach (string coffee in coffeeList)
{
    Console.WriteLine($"Kahve {num}: {coffee}");
    num++;
}


