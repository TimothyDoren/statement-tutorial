int[] nbrs = {

   754, 233, 509, 792, 700, 596, 833, 658, 998, 742,

   187, 754, 308, 914, 489, 867, 717, 586, 929, 467,

   460, 241, 770, 324, 599, 259, 120, 800, 336, 609,

   690, 134, 598, 249, 282, 574, 334, 956, 659, 214,

   435, 643, 809, 874, 906, 620, 328, 369, 426, 561

};
int lowest = 1000;
int highest = 1;
int currentNum;
foreach(int number in nbrs)
{
    if(number < lowest)
    {
        currentNum = number;
        lowest = currentNum; 
    }
}

Console.WriteLine(lowest);
foreach (int number in nbrs)
{
    if (number > highest)
    {
        currentNum = number;
        highest = currentNum;
    }
}

Console.WriteLine(highest);













/*
string [] names = { "rob", "trevor", "jacob", "jason", "lynn", "jace", "jake", "skyler", "zack", "tim" };
foreach(string name in names){
    Console.WriteLine(name);
}

*/

/*
int sum = 0;
for (int i = 0; i <= 50; i++)
{
    if (i % 2 != 0)
    {
        sum = sum + i;
    }
}
*/

/*
Console.Write("Enter an integer: ");
string? answerString = Console.ReadLine();
int answer = Convert.ToInt32(answerString);
string evenOdd = "";
if (answer % 2 == 0)
{
    Console.WriteLine("The number is Even!");
    evenOdd = "Even";
}
else
{
    Console.WriteLine("The number is Odd!");
    evenOdd = "Odd";
}
Console.WriteLine($"The number {answer} is {evenOdd}");
*/