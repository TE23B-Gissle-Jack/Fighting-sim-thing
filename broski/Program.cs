
Fight();
static void Fight()
{
    while (true)
    {


        int p1Hp = 100;
        int player1BaseAttack = 10;
        float p1HitChance = 1;

        int p2Hp = 100;
        int player2BaseAttack = 10;
        float p2HitChance = 1;


        string p1Name = GetPlayerName();
        string p2Name = "Potatis";

        while (p1Hp > 0 && p2Hp > 0)
        {
            Console.WriteLine($"{p1Name}:{p1Hp}");
            Console.WriteLine($"{p2Name}:{p2Hp}");
            p2Hp -= Attack(false, player1BaseAttack, p1HitChance, p1Name, p2Name);
            p1Hp -= Attack(true, player2BaseAttack, p2HitChance, p2Name, p1Name);

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

        Console.WriteLine("will du slåss igen?");
        string svar = "";
        while (svar.ToLower() != "ja" && svar.ToLower() != "nej")
        {
            Console.WriteLine("Ja eller Nej");
            svar = Console.ReadLine();
        }
        if (svar.ToLower() == "nej")
        {
            break;
        }

    }


    static string GetPlayerName()
    {
        Console.WriteLine("vad heter du?");

        string getName = Console.ReadLine();
        while (getName == null || getName.Length < 1)
        {
            Console.WriteLine("Ange ett namn med minst en karaktär");
            getName = Console.ReadLine();
        }
        return getName;
    }
    static int Attack(bool ai, int dmg, float hitChanceMult, string name, string op)
    {
        string svar = "";
        if (ai)
        {
            if (Random.Shared.Next(2) == 1) svar = "a";
            else svar = "b";
        }
        else
        {
            Console.WriteLine("Välj en Attack");
            Console.WriteLine($"a) Slå och gör {dmg} skada med {90 * hitChanceMult}% chance att träffa");
            Console.WriteLine($"b) Sparka och gör {dmg * 3} skada med {20 * hitChanceMult}% chance att träffa");
            Console.ForegroundColor = ConsoleColor.Magenta;

            while (svar.ToLower() != "a" && svar.ToLower() != "b")
            {
                Console.WriteLine($"Skrive a/b för att välja");
                svar = Console.ReadLine();
            }
        }
        if (svar.ToLower() == "a")
        {
            if (Random.Shared.Next(100) < hitChanceMult * 90)
            {
                Console.WriteLine($"{name} slog {op} och gjorde {dmg}");
                return dmg;
            }
            Console.WriteLine($"{name} försökte slå {op} men missade");
            return 0;
        }

        if (Random.Shared.Next(100) < hitChanceMult * 20)
        {
            Console.WriteLine($"{name} sparka {op} och gjorde {dmg*3}");
            return dmg * 3;
        }
        Console.WriteLine($"{name} försökte sparka {op} men missade");


        return 0;
    }
}

