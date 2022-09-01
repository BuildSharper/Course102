Console.WriteLine("Let's make a grocery list!");

//creating a List of strings rather than an array, because we don't know how many grocery items we'll need
var groceryList = new List<string>();

var done = false;

//we'll continue asking for more groceries until they type 'done'
while (!done)
{
    Console.Write("Enter a grocery item (type 'done' when finished):");
    var item = Console.ReadLine();

    //make sure the item isn't null
    if (item != null)
    {
        if (item.ToUpper().Trim() == "DONE")
        {
            //if the user types 'done', set the done variable to true so we exit the while loop
            done = true;
        }
        else
        {
            //the user typed another grocery item, so let's add it to the list
            groceryList.Add(item);
        }
    }
}

//clear the screen
Console.Clear();

Console.WriteLine("-------------------------------------");
Console.WriteLine("My Grocery List");
Console.WriteLine("-------------------------------------");

//loop through the groceryList and display the items
foreach (var item in groceryList)
{
    Console.WriteLine($" - {item}");
}

Console.WriteLine("Press any key to continue.");
Console.ReadLine();