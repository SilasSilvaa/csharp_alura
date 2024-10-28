partial class Program
{
    static void UseConsoleStream()
    {
        string newPathFile = @"C:\_\CsharpFiles\ByteBankIO\console.txt";

        using (var stream = Console.OpenStandardOutput())
        using (var fileStream = new FileStream(newPathFile, FileMode.Create))
        {
            byte[] buffer = new byte[1024];

            while (true)
            {
                int readBytes = stream.Read(buffer, 0, buffer.Length);
                
                fileStream.Write(buffer, 0, readBytes);
                fileStream.Flush();

                Console.WriteLine($"Bytes lidos na console: {readBytes}");

            }

        }
    }
}
