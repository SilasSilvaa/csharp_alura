using System.Text;

partial class Program
{
    static void DealingWithFilestreamDirectly(string[] args)
    {
        string filePath = "/_/CsharpFiles/contas.txt";

        using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
        {
            int byteNumberRead = -1;
            byte[] buffer = new byte[1024]; // 1KB


            while (byteNumberRead != 0)
            {
                byteNumberRead = fileStream.Read(buffer, 0, 1024);
                ReadBuffer(buffer, byteNumberRead);
            }

            //fileStream.Close();
        }
    }

    private static void ReadBuffer(byte[] buffer, int readBytes)
    {
        var utf8 = new UTF8Encoding();
        string text = utf8.GetString(buffer, 0, readBytes);
        Console.Write(text);

    }
}