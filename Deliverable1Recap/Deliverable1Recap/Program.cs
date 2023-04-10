int sodaCount = 100;
int sodaRestock = 40;

int chipsCount = 40;
int chipsRestock = 20;

int candyCount = 60;
int candyRestock = 40;

Console.WriteLine("How many sodas have been sold? 100 are in stock");
string sodaSold = Console.ReadLine();
int s = int.Parse(sodaSold);

if (s > sodaCount)
{
    Console.WriteLine("Number to high soda stock not adjusted");
}
else
{
    sodaCount -= s;
    Console.WriteLine($"{s} sodas have been sold. {sodaCount} sodas are left in stock");
}

Console.WriteLine("How many chips have been sold? 40 are in stock");
string chipsSold = Console.ReadLine();
int c = int.Parse(chipsSold);

if (c > chipsCount)
{
    Console.WriteLine("Number to high chip stock not adjusted");
}
else
{
    chipsCount -= c;
    Console.WriteLine($"{c} chips have been sold. {chipsCount} chips are left in stock");
}

Console.WriteLine("How many candies have been sold? 60 are in stock");
string candySold = Console.ReadLine();
int can = int.Parse(candySold);

if (can > candyCount)
{
    Console.WriteLine("Number to high candy stock not adjusted");
}
else
{
    candyCount -= can;
    Console.WriteLine($"{can} candies have been sold. {candyCount} candies are left in stock");
}

if (sodaCount <= sodaRestock) { 
    Console.WriteLine("Sodas need to be restocked");
}
if (chipsCount <= chipsRestock)
{
    Console.WriteLine("Chips need to be restocked");
}
if (candyCount <= candyRestock)
{
    Console.WriteLine("Candys need to be restocked");
}