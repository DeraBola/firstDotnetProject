// Recommended expression 
// string[] fraudulentOrderIDs = {"A123", "B456", "C789"};


int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;

foreach (int items in inventory)
{
sum += items;
}
Console.WriteLine($"we have {sum} items in the inventory");
