using ByteBankIO;
using System.Text;
using System.Text.Unicode;

partial class Program
{
    static void Main(string[] args)
    {
        BinaryReadFile();
    }

    private static void ReadFileAndConvertToAccount()
    {
        var fileAddress = "/_/CsharpFiles/contas.txt";

        using (var streamFile = new FileStream(fileAddress, FileMode.Open))
        {
            var reader = new StreamReader(streamFile);
            //var line = reader.ReadLine();
            //var text = reader.ReadToEnd();
            //var number = reader.Read();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                CurrentAccount currentAccount = ConvertStringToToCurrentAccount(line);

                Console.WriteLine(currentAccount.Owner.Name);
            }
            Console.WriteLine();
        }
    }

    private static CurrentAccount ConvertStringToToCurrentAccount(string line)
    {
        var data = line.Split(",");
        var agency = int.Parse(data[0]);
        var number = int.Parse(data[1]);
        var salary = double.Parse(data[2].Replace(".", ","));
        var owner = data[3];

        CurrentAccount resutl = new CurrentAccount(agency, number);
        
        Client client = new Client();
        client.Name = owner;
        
        resutl.Deposit(salary);
        resutl.Owner = client;

        return resutl;
    }

    private static void ClassFile()
    {
        Console.WriteLine("Digite seu nome:");
        var name = Console.ReadLine();

        var lines = File.ReadAllLines(@"/_/CsharpFiles/contas.txt");
        Console.WriteLine(lines.Length);

        foreach(var line in lines)
        {
            Console.WriteLine(line);
        }

        byte[] fileBytes = File.ReadAllBytes(@"/_/CsharpFiles/contas.txt");

        Console.WriteLine($"Arquivo contas.txt possui {fileBytes.Length} bytes");
        File.WriteAllText("/_/CsharpFiles/contas2.txt", "Testando o File.WirterAllText");
    }
}