using ManipulaArquivos;

string path = @"C:\DadosEstoque\";
string file = "products.txt";

Product CreateProduct()
{
    Console.WriteLine("Informe um Id");
    var id = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe a descrção do produto");
    string description = Console.ReadLine();

    Console.WriteLine("Informe o preço");
    double price = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe a quantidade disponivel: ");
    int qtd = int.Parse(Console.ReadLine());

    return new(id,description,price,qtd);
}

void ShowAll(List <Product> l)
{
    foreach (Product p in l)
    {
        Console.WriteLine(p.ToString());
    }
}

bool CheckIfExist(string p, string f)
{
    if (!Directory.Exists(p))
        Directory.CreateDirectory(p);

    if (!File.Exists(p + f))
        File.Create(p + f);
    return true;
}

void SaveFile(List <Product> list, string ph, string f)
{
    if (CheckIfExist(ph, f))
    {
        StreamWriter streamWriter = new StreamWriter(ph + f);

        foreach (Product p in list)
        {
            streamWriter.WriteLine(p.ToString());
        }
        streamWriter.Close();
    }    
}

List <Product> LoadFile(string ph, string f)
{
    List <Product> l = new List <Product>();

    if (CheckIfExist(ph,f))
    {
        StreamReader reader = new StreamReader(ph + f);
        string[] data = new string[4];
        foreach (var linha in File.ReadAllLines(ph + f))
        {
            data = linha.Split(";");
            l.Add(new Product(int.Parse(data[0]), data[1], double.Parse(data[2]), int.Parse(data[3])));
        }
    }
    return l;
}


List <Product> products = new List <Product>();

Console.WriteLine("Cadastro de produtos");

products.Add(CreateProduct());

ShowAll(products);

products.Add(CreateProduct());

ShowAll(products);

SaveFile(products, path, file);
