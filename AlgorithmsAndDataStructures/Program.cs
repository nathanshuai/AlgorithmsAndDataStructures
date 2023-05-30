//prompt user for integer n, which serves as array length of word list 

using System;

int n = 0;

while (n <= 0)

{ //form validation

    Console.WriteLine("please enter integer value greater than zero ");

    n = Int32.Parse(Console.ReadLine());
}



string[] words = new string[n]; //get console entered amount 

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Please enter words {i + 1}:");

    string newWord = Console.ReadLine();

    if (newWord.Length > 0 && !newWord.Contains(' '))
    {
        words[i] = newWord.ToLower();
    }
    else
    {
        Console.WriteLine("sorry but you must enter at least one charcter and no space between word");
        i--;
    }
}


// consoleKeyInfor

char charToCount = ' ';
while (!Char.IsLetter(charToCount))
{
    Console.WriteLine("please enter a character to count");
    charToCount = Char.ToLower(Console.ReadKey().KeyChar);

}


Console.WriteLine($"\n You enterd the character '{charToCount}'");

// get a count of how many times this character appears in all of the words

int charCount = 0;
foreach (string word in words)
{
    char[] chars = word.ToCharArray();

    foreach (char c in chars)
    {
        if (c == charToCount)
        {
            { charCount++; }
        }
    }
}

// get totalcount of character in all of the words

int charTotalCount = 0;

foreach (string word in words)
{
    char[] chars = word.ToCharArray();

    charTotalCount += chars.Length;
}

if (charCount / (double)charTotalCount > 0.25)
{
    Console.WriteLine($" The letter '{charToCount}' appears {charCount} times in the array." +
        $"This letter makes up more than 25% of the total number of characters. ");
}
else
{
    Console.WriteLine($" The letter '{charToCount}' appears {charCount} times in the array.");
}

//Why not just use BigInteger? because the count of letters is within the range of a 32-bit signed integer.
//Using BigInteger will impact on performance and memory usage.
