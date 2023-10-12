using System.Text;

string pathToDir = @"C:\FileSystem\PV_211";
string pathToFile = pathToDir + @"\data.txt";
if (!Directory.Exists(pathToDir))
{
    Directory.CreateDirectory(pathToDir);
}
if (!File.Exists(pathToFile))
{
    File.Create(pathToFile);
}
Console.WriteLine("Enter message: ");
string mes = Console.ReadLine();
File.WriteAllText(pathToFile, mes, Encoding.Unicode);



string content = File.ReadAllText(pathToFile);
Console.WriteLine("Our content: " + content);
