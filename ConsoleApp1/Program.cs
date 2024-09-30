//string name = "Brian";

//string result = "6" + "4";

//Console.WriteLine(result);

using System.Net;
using System.Text.Encodings.Web;

int hp = 100;

hp = hp - 10;
hp -= 10;
hp -= 10;
Console.WriteLine("Välkommen till en random frågesport");

//--------------------------------------------------------------------

Console.WriteLine("vad heter den nuvarande presidenten för ryssland?");
Console.WriteLine("a) Joe biden b) Putin c) Obama");
string svar1 = Console.ReadLine();
if (svar1 == "b")
{
hp++;
Console.WriteLine("Correct Bra Jobbat");
}
else
{
    Console.WriteLine("INCORRECT DIN NOOB");
}

//nästa-----------------------------------------------
Console.WriteLine("vem är det som skrivit denna frågesport?");
Console.WriteLine("a) Albert b) Jag c) Brian");
string svar2 = Console.ReadLine();
if(svar1 == "c");
{
    hp++;
Console.WriteLine("Grymt jobbat!,");
}
//nästa-----------------------------------------------
Console.WriteLine("vem fightas mot skurkar på natten i läder");
Console.WriteLine("a) Black noir b) Spiderman c) Batman");
string svar3 = Console.ReadLine();
if(svar1 == "c");
{
    hp++;
Console.WriteLine("Bra svar!");
}
