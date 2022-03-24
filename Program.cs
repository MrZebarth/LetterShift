// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter a sentence");
String message = "";
message = Console.ReadLine();
Console.WriteLine(Code(message));



static string Code(string sSentence)
{
    //find the length of the message
    byte msgLength = 0;
    String output = "";
    for (int x = 0; x < sSentence.Length; x++)
    {
        if (Char.IsLetter(sSentence[x]))
        {
            msgLength++;
        }
    }

    //Loop through, adjust the character, add it to the String
    for (int x=0; x < sSentence.Length; x++)
    {
        //first make sure it's a letter
        if (!Char.IsLetter(sSentence[x]))
        {
            output+=sSentence[x];
            continue;
        }
        byte result = Convert.ToByte(sSentence[x]);
        result += msgLength;
        //Check for overflow
        if ((Char.IsUpper(sSentence[x]) && result>'Z') || (Char.IsLower(sSentence[x]) && (result > 'z'))){
            result -= 26;
        }
        char cChar = Convert.ToChar(result);
        output += cChar;

    }
    return output;
}