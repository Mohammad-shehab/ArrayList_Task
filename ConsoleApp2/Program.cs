
using System.Collections;
using System.Reflection.Metadata.Ecma335;
using System.Transactions;


//task 1
#region task 1
//Create an ArrayList to hold various grocery or fruit items.
ArrayList arrayList = new ArrayList()
{
"orange",
"grape",
"watermelon",
"Peach",
"Blueberry"
};


//Adding elements to the list
arrayList.Add("banana");
arrayList.Add("apple");
arrayList.Add("cherry");
Console.WriteLine($"----------------------------------------------");

// Print out all elements in the ArrayList to confirm they were added successfully
foreach (var i in arrayList)
{
    Console.WriteLine(i);
};
Console.WriteLine($"----------------------------------------------");


//ArrayList Methods

arrayList.Insert(2, "orange"); //inserting orange at index 2
arrayList.RemoveAt(4); //removing the item of index 4

// Print out all elements in the ArrayList to check if they were modigied correctly
foreach (var i in arrayList)
{
    Console.WriteLine(i);
};
Console.WriteLine($"----------------------------------------------");

//Contains: Check if a particular value (e.g., “banana”) exists in the ArrayList. Print out the result.

Console.WriteLine("pick a fruit: ");
string check = Console.ReadLine().ToLower();
while (  arrayList.Contains(check)==false)       //using contains
{
    Console.WriteLine("does not exist try again: ");
    Console.WriteLine(": ");
    check = Console.ReadLine();
}

if (arrayList.Contains(check))
{
    Console.WriteLine("item exists. ");
    Console.WriteLine("the index of " + check + " is: " + arrayList.IndexOf(check)); //using index

}
Console.WriteLine($"----------------------------------------------");

Console.WriteLine("number of items: " + arrayList.Count);     //using count

#endregion
Console.WriteLine($"----------------------------------------------");


//bonus 
#region bonus
ArrayList integerslist = new ArrayList()
{
11,
200,
323,
654,
23,
1,
44,
15
};

Console.WriteLine($"Enter Threshold");
int threshhold = Convert.ToInt32(Console.ReadLine());

ArrayList GreaterThanTreshold(ArrayList input,int num)
{
    ArrayList filteredlist = new ArrayList();
    foreach(int i in input )
    {
        if(i > num)
        {
            filteredlist.Add(i);
        }
    }
    return filteredlist;
}

var x= GreaterThanTreshold(integerslist, threshhold);
foreach(int i in x)
{
    Console.WriteLine(i);
}















#endregion











