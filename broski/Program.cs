int p1Hp = 100;
int p2Hp = 100;

string p1Name = "Korv";
string p2Name = "Potatis";

while ((p1Hp) > 0 && p2Hp > 0)
{
    Console.WriteLine($"{p1Name}:{p1Hp}");
    Console.WriteLine($"{p2Name}:{p2Hp}");
    p2Hp -= Random.Shared.Next(5, 50);
    p1Hp -= Random.Shared.Next(5, 50);

    Console.ReadLine();
}
if (p1Hp <= 0 && p2Hp <= 0)
{
    Console.WriteLine("Lika!");
}
else if (p1Hp <= 0)
{
    Console.WriteLine($"{p2Name} van");
}
else
{
    Console.WriteLine($"{p1Name} van");
}

Console.ReadLine();