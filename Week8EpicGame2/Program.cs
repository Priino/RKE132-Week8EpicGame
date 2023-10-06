string folderPath = @"C:\Massiivid\";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile)); //(folderPath+heroFile
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));                                                                        //
string[] weapons = { "magic wand", "plastic fork", "banana", "Wooden sword", "Lego brick" };

string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapons);
Console.WriteLine($"Today {hero} saves the day with {heroWeapon}");


string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapons);
Console.WriteLine($"Today {villain} tries to take over the world with {villainWeapon}");

static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArry = someArray[randomIndex];
    return randomStringFromArry;
}