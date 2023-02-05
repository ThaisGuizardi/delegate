
int result = 0;

#region Delegate Sum

DelegateMethod delegateMethodSum = CalcSum;

result = delegateMethodSum(10, 10);

Console.WriteLine($"Sum: {result}");

Console.WriteLine("\n");

#endregion

#region Delegate Mult

DelegateMethod delegateMethodMult = CalcMult;

result = delegateMethodMult(10, 10);

Console.WriteLine($"Mult: {result}");

Console.WriteLine("\n");

#endregion

#region Predicate

bool resultPredicate = false;

Predicate<int> predicate;

predicate = EvenNumber;

resultPredicate = predicate(5);

Console.WriteLine($"Even Number: {resultPredicate}");

List<int> ints = new List<int>();

ints.Add(10);
ints.Add(11);
ints.Add(12);
ints.Add(13);
ints.Add(14);
ints.Add(15);

Console.WriteLine("\n");

Console.WriteLine("Print Ints:");

PrintInts(ints);

Console.WriteLine("\n");

List<int> evenInts = new List<int>();

evenInts = ints.FindAll(predicate);

Console.WriteLine("Print Even Ints:");

PrintInts(evenInts);

#endregion

Console.Read();

static int CalcSum(int v1, int v2) => v1 + v2;

static int CalcMult(int v1, int v2) => v1 * v2;

static bool EvenNumber(int value) => value % 2 == 0;

static void PrintInts(List<int> ints)
{
    for (int i = 0; i < ints.Count; i++)
        Console.WriteLine(ints[i]);
}

delegate int DelegateMethod(int a, int b);