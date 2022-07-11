global using System.Text;
global using PBandJEncoderDecoder;

Console.Title = "PB&J Encoder & Decoder";

Console.WriteLine("PB&J Encoder & Decoder v1.0\n");

while (true)
{
    Console.WriteLine("\nType \"encode\" to convert into PB&J code or \"decode\" to decode a PB&J code to original character.");

    Console.Write("\n>> ");

    string option = Console.ReadLine();

    if (option is "encode")
    {
        Console.WriteLine("Type your characters to encode into PB&J code:");

        Console.Write("\n>> ");

        string input = Console.ReadLine();

        Console.WriteLine($"Encode result:\n{EncoderDecoderUtilities.Encode(input)}\n\nPress ENTER key to return...");

        Console.ReadLine();
    }

    else if (option is "decode")
    {
        Console.WriteLine("Type your PB&J code to decode into its original characters:");

        Console.Write("\n>> ");

        string input = Console.ReadLine();

        Console.WriteLine($"Decode result:\n{EncoderDecoderUtilities.Decode(input)}\n\nPress ENTER key to return...");

        Console.ReadLine();
    }

    else
    {
        // Void it or tell the user it is the incorrect option?
    }
}