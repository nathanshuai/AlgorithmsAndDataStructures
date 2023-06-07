
//Write, test, and then refactor the following methods as you see fit. They should validate their inputs
//and provide a reasonable response for incorrect input. Be sure to include in comments the Time Complexity
//of your given solution. 



//List<int> MaxNumbersInLists(List<List<int>>) accepts as a parameter a List of Lists of Integers.
//It returns a new list with each element representing the maximum number found in the corresponding original list. 
//For example, { {1, 5, 3}, { 9, 7, 3, -2}, { 2, 1, 2} } returns {5, 9, 2}.
//Output the results with a message like: “List 1 has a maximum of 5.
//List 2 has a maximum of 9. List 3 has a maximum of 2.”

int GetHighestValueInList(List<int> list)
{
    if (list == null || list.Count == 0)
    {
        throw new ArgumentException("The list cannot be null or empty.");
    }

    int max = int.MinValue;

    foreach (int num in list)
    {
        if (num > max)
        {
            max = num;
        }
    }

    return max;
}

List<int> MaxNumbersInLists(List<List<int>> lists)
{
    if (lists == null || lists.Count == 0)
    {
        throw new ArgumentException("The lists cannot be null or empty.");
    }
    
    List<int> maxNumbers = new List<int>();

    foreach (List<int> list in lists)
    {
        int max = GetHighestValueInList(list);

        maxNumbers.Add(max);
    }

    return maxNumbers;
}

List<List<int>> lists = new List<List<int>>
{
    new List<int> { 1, 5, 3 },
    new List<int> { 9, 7, 3, -2 },
    new List<int> { 2, 1, 2 }
};

List<int> result = MaxNumbersInLists(lists);

for (int i = 0; i < result.Count; i++)
{
    Console.WriteLine("List " + (i + 1) + " has a maximum of " + result[i] + ".");
}
//The Time Complexity is ON;



//String HighestGrade(List<List<int>>) accepts a list of number grades among students in different
//courses (where each list represents a single course), between 0 and 100. It returns the highest
//grade among all students in all courses.
//For example: { { 85,92, 67, 94, 94}, { 50, 60, 57, 95}, { 95} }
//returns "The highest grade is 95. This grade was found in class(es) {index}".

string HighestGrade(List<List<int>> grades)
{
    if (grades == null || grades.Count == 0)
    {
        return "No grades available.";
    }

    int maxGrade = int.MinValue;
    List<int> maxGradeIndexes = new List<int>();

    for (int i = 0; i < grades.Count; i++)
    {
        foreach (int grade in grades[i])
        {
            if (grade > maxGrade)
            {
                maxGrade = grade;
                maxGradeIndexes.Clear();
                maxGradeIndexes.Add(i);
            }
            else if (grade == maxGrade)
            {
                maxGradeIndexes.Add(i);
            }
        }
    }

    string gradeString = "The highest grade is " + maxGrade + ". ";

    if (maxGradeIndexes.Count == 1)
    {
        gradeString += "This grade was found in class " + maxGradeIndexes[0] + ".";
    }
    else
    {
        gradeString += "This grade was found in classes ";

        for (int i = 0; i < maxGradeIndexes.Count; i++)
        {
            gradeString += maxGradeIndexes[i].ToString();

            if (i < maxGradeIndexes.Count - 1)
            {
                gradeString += ", ";
            }
        }

        gradeString += ".";
    }

    return gradeString;
}

List<List<int>> grades = new List<List<int>>
{
    new List<int> { 85, 92, 67, 94, 94 },
    new List<int> { 50, 60, 57, 95 },
    new List<int> { 95 }
};

string highestGrade = HighestGrade(grades);
Console.WriteLine(highestGrade);
// the time complexity is O(n^m), m as the maximum number of grades in any individual list.


//List<int> OrderByLooping (List<int>) orders a list of integers, from least to greatest,
//using only basic control statements(ie. if/else, for/while).
//For example, argument {6, -2, 5, 3} returns {-2, 3, 5, 6}.

List<int> OrderByLooping(List<int> numbers)
{
    if (numbers == null || numbers.Count <= 1)
    {
        return new List<int>();
    }

    int n = numbers.Count;

    for (int i = 0; i < n - 1; i++)
    {
        int minIndex = i;

        for (int j = i + 1; j < n; j++)
        {
            if (numbers[j] < numbers[minIndex])
            {
                minIndex = j;
            }
        }

        if (minIndex != i)
        {
            int temp = numbers[i];
            numbers[i] = numbers[minIndex];
            numbers[minIndex] = temp;
        }
    }

    return numbers;
}

List<int> numbers = new List<int> { 6, -2, 5, 3 };
List<int> orderedNumbers = OrderByLooping(numbers);
Console.WriteLine(string.Join(", ", orderedNumbers));
// the time complexity is O(n^2)


//Bonus:
//Once you finish these methods, do some research into bubble sorting. refactor OrderByLooping method to use it

List<int> BubbleSort(List<int> numbers)
{
    if (numbers == null || numbers.Count <= 1)
    {
        return new List<int>();
    }

    int n = numbers.Count;

    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - 1; j++)
        {
            if (numbers[j] > numbers[j + 1])
            {
                // Swap the elements
                int temp = numbers[j];
                numbers[j] = numbers[j + 1];
                numbers[j + 1] = temp;
            }
        }
    }

    return numbers;
}

List<int> numbers1 = new List<int> { 6, -2, 5, 3 };
List<int> sortedNumbers = BubbleSort(numbers1);
Console.WriteLine(string.Join(", ", sortedNumbers));
// the time complexity is O(n^2)


// Bubble sort works by repeatedly iterating through the list and 
// comparing adjacent elements. if the elements are in the wrong order
//they are swapped. This process is repeated until the list is sorted.

