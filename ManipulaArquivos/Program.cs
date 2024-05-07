string path;
string file = "arquivo.txt";

path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Dados\\";
//path = @"C:\Dados\";

if (!Directory.Exists(path))
    Directory.CreateDirectory(path);
if (File.Exists(path + file))
{
    StreamReader sr = new StreamReader(path + file);    
    Console.WriteLine("Digite um nome: ");
    string s = sr.ReadToEnd();
    s += "\n";
    s += Console.ReadLine();
    sr.Close();
    StreamWriter sw = new StreamWriter(path + file);
    sw.WriteLine(s);
    sw.Close();

    sr = new StreamReader(path + file);
    Console.WriteLine(sr.ReadToEnd());

    string retorno = File.ReadLines(path + file).ElementAt(4);
    Console.WriteLine(retorno);
}
else
{
    File.Create(path + file);
    StreamWriter sw = new StreamWriter(path + file);
    Console.WriteLine("Digite: ");
    sw.WriteLine(Console.ReadLine());
    sw.Close();

    StreamReader sr = new StreamReader(path + file);
    string s = sr.ReadToEnd();
    sr.Close();

    sw = new StreamWriter(path + file);

    sw.Write(s+ "\n" + Console.ReadLine());

}



/*StreamReader sr = new(path + file);
StreamWriter sw = new(path + file);

Console.WriteLine("Informe seu nome");
string s = Console.ReadLine();


sw.WriteLine(s); // escreve linha no arquivo


Console.WriteLine("Informe seu email: ");
s = Console.ReadLine();

sw.WriteLine(s); // escreve linha no arquivo
sw.Close(); // fecha arquivo

Console.Clear();
Console.WriteLine(sr.ReadToEnd());
sr.Close();*/