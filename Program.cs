// See https://aka.ms/new-console-template for more information
// 1. Iterate and print values
static void PrintList(List<string> MyList)
{
    // foreach( string name in MyList){
    //     Console.WriteLine(name);
    // }

    // MyList.ForEach(name => Console.WriteLine(name));

    //     for(int i = 0; i < MyList.Count; i++){
    //         Console.WriteLine(MyList[i]);
    //     }
    Console.WriteLine("Test 1: ");
    Console.WriteLine(string.Join(", ", MyList));
}
List<string> TestStringList = new List<string>() { "Harry", "Steve", "Carla", "Jeanne" };

PrintList(TestStringList);

// 2. Print Sum
static void SumOfNumbers(List<int> IntList)
{
    int sum = 0;

    foreach (int num in IntList)
    {
        sum += num;
    }
    Console.WriteLine("Test 2:" + sum);
}
List<int> TestIntList = new List<int>() { 2, 7, 12, 9, 3 };
// You should get back 33 in this example
SumOfNumbers(TestIntList);

// 3. Find Max
static int FindMax(List<int> IntList)
{
    int max = IntList[0];
    for (int i = 0; i < IntList.Count; i++)
    {
        if (IntList[i] > max)
        {
            max = IntList[i];
        }
    }

    Console.WriteLine("Test 3: " + max);
    return max;
}
List<int> TestIntList2 = new List<int>() { -9, 12, 10, 3, 17, 5 };
// You should get back 17 in this example
FindMax(TestIntList2);

// 4. Square the Values
static List<int> SquareValues(List<int> IntList)
{
    List<int> newList = new List<int>();

    int temp = 0;

    for (int i = 0; i < IntList.Count; i++)
    {

        temp = IntList[i] * IntList[i];
        newList.Add(temp);
    }

    Console.WriteLine("Test 4: ");
    foreach (int num in newList)
    {
        Console.WriteLine(num);
    }

    return newList;

}
List<int> TestIntList3 = new List<int>() { 1, 2, 3, 4, 5 };
// You should get back [1,4,9,16,25], think about how you will show that this worked
SquareValues(TestIntList3);

// 5. Replace Negative Numbers with 0

static int[] NonNegatives(int[] IntArray)
{
    for(int i = 0; i < IntArray.Length; i++){
        if(IntArray[i] < 0){
            IntArray[i] = 0;
        }
    }
    return IntArray;
}
int[] TestIntArray = new int[] {-1,2,3,-4,5};
// You should get back [0,2,3,0,5], think about how you will show that this worked
NonNegatives(TestIntArray);
Console.WriteLine("Test 5: ");
Console.WriteLine(string.Join(", ", NonNegatives(TestIntArray)));

// 6. Print Dictionary

static void PrintDictionary(Dictionary<string,string> MyDictionary)
{
    foreach(KeyValuePair<string,string> keyPair in MyDictionary){
        Console.WriteLine($"{keyPair.Key} - {keyPair.Value}");
    }
}
Dictionary<string,string> TestDict = new Dictionary<string,string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
Console.WriteLine("Test 6: ");
PrintDictionary(TestDict);

//7. Find Key

static bool FindKey(Dictionary<string,string> MyDictionary, string SearchTerm)
{
    if(MyDictionary.ContainsKey(SearchTerm))
    {
        return true;
    }
    else
    {
        return false;
    }
}
// Use the TestDict from the earlier example or make your own

Console.WriteLine("Test 7 : ");
// This should print true
Console.WriteLine("Expected: true");
Console.WriteLine(FindKey(TestDict, "RealName"));
// This should print false
Console.WriteLine("Expected: false");
Console.WriteLine(FindKey(TestDict, "Name"));


//8. Generate a Dictionary
// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
//	"Julie": 6,
//	"Harold": 12,
//	"James": 7,
//	"Monica": 10
// } 
static Dictionary<string,int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    Dictionary<string,int> ResultDict = new Dictionary<string,int>();

    for(int i = 0; i < Names.Count; i++){
        ResultDict.Add(Names[i], Numbers[i]);
    }

    Console.WriteLine("Test 8: ");

    foreach(KeyValuePair<string,int> keyPair in ResultDict){
        Console.WriteLine($"{keyPair.Key} - {keyPair.Value}");
    }

    return ResultDict;
}
// We've shown several examples of how to set your tests up properly, it's your turn to set it up!
// Your test code here
List<int> TestList8 = new List<int>() {6,12,7,10};
GenerateDictionary(TestStringList, TestList8 );
