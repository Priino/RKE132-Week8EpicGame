//string folderPath = @"C:\Massiivid\";
//string chuckJokeFile = "chuck.txt";

//string[] chuck = File.ReadAllLines(Path.Combine(folderPath, chuckJokeFile)); //(folderPath+heroFile)
//string chuckJoke = GetRandomJoke(chuck);

//Console.WriteLine($"{chuckJoke}");

//static string GetRandomJoke(string[] someArray)
//{
//    Random rnd = new Random();
//    int randomIndex = rnd.Next(0, someArray.Length);
//    string randomStringFromArry = someArray[randomIndex];
//    return randomStringFromArry;
//}



//string path = @"C:\Massiivid\";
//string fileName = "chuck.txt";
//string[] lines = File.ReadAllLines(Path.Combine(path, fileName));
//Console.WriteLine(lines.Length);



//string path = @"C:\Massiivid\";
//string fileName = "chuck.txt";
//string[] lines = File.ReadAllLines(Path.Combine(path, fileName));
//Console.WriteLine(GetJoke(lines));
//static string GetJoke(string[] jokeArray)
//{
//    Random rnd = new Random();
//    return jokeArray[rnd.Next( 9, jokeArray.Length)];
//}



string path = @"C:\Massiivid\";
string fileName = "chuck.txt";
string[] lines = File.ReadAllLines(Path.Combine(path, fileName));

ShowFileContent(lines);

static void ShowFileContent(string[] fileContentArray)
{
    int i = 1;
    foreach (string line in fileContentArray)
    {
        Console.WriteLine($"{i}. {line}");
        i++;
    }
}