using System.Data;
using System.Text;

partial class Program
{
    static void CreateFile()
    {
        string newPathFile = @"C:\_\CsharpFiles\ByteBankIO\exportAccounts.csv";

        using (FileStream fileStream = new FileStream(newPathFile, FileMode.Create))
        {
            var accountString = "456, 7895, 4785.40, Name";

            Encoding uTF8 = Encoding.UTF8;

            byte[] bytes = uTF8.GetBytes(accountString);

            fileStream.Write(bytes, 0, bytes.Length);
        }
    }

    static void CreateFileWithWriter()
    {
        string newPathFile = @"C:\_\CsharpFiles\ByteBankIO\exportAccounts.csv";

        using (FileStream fileStream = new FileStream(newPathFile, FileMode.Create))
        using (StreamWriter streamWriter = new StreamWriter(fileStream))
        {
            streamWriter.Write("456, 7895, 4785.40, Name 2");
        }

    }

    static void WriteTest()
    {
        string newPathFile = @"C:\_\CsharpFiles\ByteBankIO\test.txt";
        using (FileStream fileStream = new FileStream(newPathFile, FileMode.Create))
        using (StreamWriter streamWriter = new StreamWriter(fileStream))
        {
            for (int i = 0; i < 100000; i++)
            {
                streamWriter.WriteLine($"Linha {i}");
                streamWriter.Flush();
                Console.WriteLine($"Linha {i} foi escrita no arquivo, telce enter...");
                Console.ReadLine();
            }
        }
    }

    static void BinaryWriteFile()
    {
        string newPathFile = @"C:\_\CsharpFiles\ByteBankIO\exportAccounts.txt";

        using (FileStream fileStream = new FileStream(newPathFile, FileMode.Create))
        using (BinaryWriter streamWriter = new BinaryWriter(fileStream))
        {
            streamWriter.Write(456);
            streamWriter.Write(5454544);
            streamWriter.Write(4000.50);
            streamWriter.Write("Name");
        }

        Console.WriteLine("Aplicação finalizada");
    }

    static void BinaryReadFile()
    {
        string newPathFile = @"C:\_\CsharpFiles\ByteBankIO\exportAccounts.txt";

        using (FileStream fileStream = new FileStream(newPathFile, FileMode.Open))
        using (BinaryReader streamReader = new BinaryReader(fileStream))
        {
            int agency = streamReader.ReadInt32();
            int accountNumber = streamReader.ReadInt32();
            double balance = streamReader.ReadDouble();
            string owner = streamReader.ReadString();

            Console.WriteLine($"agency: {agency}, number: {accountNumber}, balance: {balance}, owner: {owner}");
        }
    }
}

