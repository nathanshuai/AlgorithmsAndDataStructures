//Create new methods to solve each of the following problems.
//We have a list of integers where elements appear either once or twice. Find the elements that appeared twice in O(n) time.
//example: { 1, 2, 3, 4, 7, 9, 2, 4} returns '{2, 4}


int[] nums = { 1, 2, 3, 4, 7, 9, 2, 4 };
List<int> twiceNums = new List<int>();
HashSet<int> unique = new HashSet<int>();

foreach (int num in nums)
{
    if (unique.Contains(num))
    {
        twiceNums.Add(num);
    }
    else
    {
        unique.Add(num);
    }
}

Console.WriteLine("Twice appeared elements: " + string.Join(", ", twiceNums));


//We have two sorted int arrays which could be with different sizes. We need to merge them in a third array
//while keeping this result array sorted. Can you do that in O(n) time? Don't use any extra structures like Sets or Dictionaries
//example: { { 1, 2, 3, 4, 5}, { 2, 5, 7, 9, 13} }
//returns {1, 2, 2, 3, 4, 5, 5, 7, 9, 13}

int[,] twoDimensionalInt = new int[,] { { 1, 2, 3, 4, 5 }, { 2, 5, 7, 9, 13 } };
int rows = twoDimensionalInt.GetLength(0);
int cols = twoDimensionalInt.GetLength(1);

List<int> mergedArray = new List<int>();

int i = 0; 
int j = 0; 

while (i < cols && j < cols)
{
    int num1 = twoDimensionalInt[0, i];
    int num2 = twoDimensionalInt[1, j];

    if (num1 < num2)
    {
        mergedArray.Add(num1);
        i++;
    }
    else if (num1 > num2)
    {
        mergedArray.Add(num2);
        j++;
    }
    else
    {
        mergedArray.Add(num1);
        mergedArray.Add(num2);
        i++;
        j++;
    }
}

while (i < cols)
{
    mergedArray.Add(twoDimensionalInt[0, i]);
    i++;
}


while (j < cols)
{
    mergedArray.Add(twoDimensionalInt[1, j]);
    j++;
}


Console.WriteLine("Merged array: " + string.Join(", ", mergedArray));



//Given an integer, reverse the digits of that integer, e. g. input is 3415,
//output is 5143. What is the time complexity of your solution?

int number = 3415;
int reversed = 0;

while (number != 0)
{
    int digit = number % 10;
    reversed = reversed * 10 + digit;
    number = number / 10;
}

Console.WriteLine("Output number: " + reversed);

// the complexity of my solution is ON.