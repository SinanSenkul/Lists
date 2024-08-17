using System.Collections.Generic;
using System.Threading;

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