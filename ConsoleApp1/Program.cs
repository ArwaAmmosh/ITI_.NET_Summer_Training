using System;
public class vigenere
{
    public string Dcryption(string ciphertext, string key)
    {
        string decryptedText = "";
        int keyPos = 0;

        foreach (char character in ciphertext)
        {
            if (keyPos == key.Length)
            {
                keyPos= 0;
            }
            if (char.IsLetter(character))
            {
                int ciphertextValue;
                int keyValue;
                int basValue =char.IsUpper(character) ? 'A':'a';
                int basValuekey = char.IsUpper(key[keyPos]) ? 'A' : 'a';
                // Convert the letter to numerical values (A=0, B=1, ..., Z=25)
                if (basValue == 'A')
                {
                     ciphertextValue = character - basValue+26;
                }
                else
                {
                     ciphertextValue = character - basValue;
                }
                if (basValuekey == 'A')
                {
                    keyValue = key[keyPos] - basValuekey;
                }
                else
                {
                    keyValue = key[keyPos] - basValuekey;
                }
                // Decrypt the letter
                int decryptedValue = (ciphertextValue - keyValue +26 ) % 26;

                // Convert back to a letter
                char decryptedChar = (char)(decryptedValue + basValue);

                // Update key position
                keyPos++;
                decryptedText += decryptedChar;
            }
            else
            {
                decryptedText += character;
            }
        }

        return decryptedText;
    }
}
public class program
{
    public static void Main(string[] args)
    {
        vigenere c= new vigenere();
        Console.WriteLine(c.Dcryption("LXFOPVEFRNHR","LEMON"));
        Console.WriteLine(c.Dcryption("pxpla", "iteam"));

    }
}