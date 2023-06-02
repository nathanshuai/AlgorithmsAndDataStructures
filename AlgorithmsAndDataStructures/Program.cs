using System;
using System.Text;
//A program that produces an array of all of the characters that appear more than once in a string.
//For example, the string “Programmatic Python” would result in the array ['p','r','o','a','m','t'].

string word = "Programmatic Python";

if (!string.IsNullOrEmpty(word))
{
    char[] chars = word.ToLower().ToCharArray();
    List<char> result = new List<char>();

    for (int i = 0; i < chars.Length; i++)
    {
        if (result.Contains(chars[i])) continue;// Skip if already added to result

        {
            for (int j = i + 1; j < chars.Length - 1; j++)
            {
                if (chars[i] == chars[j])
                {
                    result.Add(chars[i]);  

                }
            }
        }   
        
    }

    char[] resultArray = result.ToArray();
    Console.WriteLine("Result in the array: " + string.Join(", ", resultArray));
}


//A program returns an array of strings that are unique words found in the argument.
//For example, the string “To be or not to be” returns ["to","be","or","not"].

string sentence = "To be or not to be";
string[] words = sentence.ToLower().Split(' ');


if (words.Length > 0)
{
    List<string> uniqueWords = new List<string>();

    foreach (string unique in words)
    {
        if (!uniqueWords.Contains(unique))
        {
            uniqueWords.Add(unique);
        }
    }
    string[] uniqueWordsArray = uniqueWords.ToArray();

    Console.WriteLine("Returns unique words: [" + string.Join(", ", uniqueWordsArray) + "]");
}


//A program that reverses a provided string 


string providedString = "hello world";
char[] chars2 = providedString.ToCharArray();
char[] reverseString = new char[chars2.Length];

for (int i = chars2.Length - 1; i >=0; i--)
{
    reverseString[chars2.Length - 1 - i] = chars2[i];
}

string reversed = new string(reverseString);
Console.WriteLine($"reversed words:{reversed}");





//A program that finds the longest unbroken word in a string and prints it
//For example, the string "Tiptoe through the tulips" would print "through"
//If there are multiple words tied for greatest length, print the last one

string tiptoe = "Tiptoe through the tulips";
string[] words1 = tiptoe.ToLower().Split(' ');

string greatestWord = "";
int greatestLength = 0;

foreach (string word1 in words1)
{
    if (word1.Length >= greatestLength)
    {
        greatestWord = word1;
        greatestLength = word1.Length;
    }
}

string lastWord = "";

foreach (string word1 in words1)
{
    if (word1.Length == greatestLength)
    {
        lastWord = word1;
    }
}

Console.WriteLine(lastWord);


//Research and employ the StringBuilder class and explain its advantages or disadvantages over Strings.


//The StringBuilder class provides a way to efficiently manipulate strings.
//It is designed to be mutable and allows you to efficiently append, insert, or modify
//characters in a sequence without creating multiple string objects.

//Advantages:
//1.mutable;
//2.Efficiently append or insert multiple strings.
//3.Reduce memory overhead when you need to repeatedly create neww strings;
//4.faster appending and modifying characters for large strings;
//Disadvantages:
//1.No immutability;
//2.Additional complexity









