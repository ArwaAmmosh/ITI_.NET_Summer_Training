class vigenere
{
    private string algorithm(string text, string key ,string state) {
        string Text = "";
        int keyPos = 0;
        int Value = 0;

        foreach (char character in text)
        {
            if (keyPos == key.Length)
            {
                keyPos = 0;
            }
            if (char.IsLetter(character))
            {
                int ciphertextValue;
                int keyValue;
                int basValue = char.IsUpper(character) ? 'A' : 'a';
                int basValuekey = char.IsUpper(key[keyPos]) ? 'A' : 'a';
                // Convert the letter to numerical values (A=0, B=1, ..., Z=25)
             
                    ciphertextValue = character - basValue;
        
                    keyValue = key[keyPos] - basValuekey ;
               
                if (state == "en")
                {
                    Value = (ciphertextValue + keyValue) % 26;
                }
                else
                {
                     Value = (ciphertextValue - keyValue + 26 ) % 26;
                }
                // Convert back to a letter
                char Char = (char)(Value + basValue);
                
                keyPos++;
                Text += Char;
            }
            else
            {
                Text += character;
            }
        }

        return Text;
    }

    public string Encryption(string plainText, string key) {
        return algorithm(plainText, key,"en");
    }
    public string Dcryption(string ciphertext, string key)
    {
        return algorithm(ciphertext,key,"de");
    }
}
class program
{
    public static void Main(string[] args)
    {
        vigenere Vigenere = new vigenere();
        Console.WriteLine(Vigenere.Encryption("hello","iteam"));
        Console.WriteLine(Vigenere.Dcryption("pxpla","iteam"));

    }
}