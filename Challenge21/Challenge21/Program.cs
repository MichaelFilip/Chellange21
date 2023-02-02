var name = "Marysia";
var age = 35;
bool female = true;

if (female && name != "Marysia" && age > 20)
{
    Console.WriteLine("NASTOLATKA");
}
else if (name == "Marysia" && age == 35)
{
    Console.WriteLine("35 latka o imieniu Marysia");
}
else if (name == "Marcin" && age < 60 && !female) 
{
    Console.WriteLine("Senior o imniu Marcin"); 
}
else
{
    Console.WriteLine("Osoba nieznana");
}

    