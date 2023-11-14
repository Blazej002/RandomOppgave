// See https://aka.ms/new-console-template for more information

using System.Security.Principal;

string[] listWithText =
{
    "You're a magician now, Congrats,", "Em.. You're trash now.. Not my fault ",
    "Im not sure but i think your new job is being my bitch..", "You're a store clerk now "
};

Console.WriteLine("Hello there, would you like a random job? y/n");

string userInput = Console.ReadLine();
if (userInput == "y" | userInput == "Y")
{
    string userName = Console.ReadLine();
    Random random = new Random();
    var rand = random.Next(listWithText.Length);
    Console.WriteLine(listWithText[rand] + " "+ userName);
}
else
{
    Environment.Exit(0);
}

