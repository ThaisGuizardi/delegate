
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

Console.WriteLine("Predicate:");
Console.WriteLine($"Even Number: {resultPredicate}");

List<int> ints = new List<int>();

ints.Add(10);
ints.Add(11);
ints.Add(12);
ints.Add(13);
ints.Add(14);
ints.Add(15);

Console.WriteLine("Print Ints:");

PrintInts(ints);

List<int> evenInts = new List<int>();

evenInts = ints.FindAll(predicate);

Console.WriteLine("Print Even Ints:");

PrintInts(evenInts);

Console.WriteLine("\n");

#endregion

#region Func

Console.WriteLine($"Func:");

Func<int> delegteFuncOne = delegate { return 1; };

int funcOne = delegteFuncOne();

Console.WriteLine($"Func One: {funcOne}");

Func<int, int> delegateFuncTwo = delegate (int paramOne) { return paramOne + 1; };

int funcTwo = delegateFuncTwo(10);

Console.WriteLine($"Func Two: {funcTwo}");

Func<int, float, float> delegateFuncThree = FuncMethod;

float funcThree = FuncMethod(10, 5.5f);

Console.WriteLine($"Func Three: {funcThree}");

Console.WriteLine("\n");

#endregion

#region Action

Action actionOne = delegate { };
actionOne();
OnClompleteFunction(actionOne);

Action<int> actionTwo = delegate (int paramOne) { };
actionTwo(1);

Action<int, float> actionThree = delegate (int paramOne, float paramTwo) { };
actionThree(10, 5.5f);

Action<int, float> actionFour = EmptyAction;
actionFour(10, 5.5f);

#endregion

#region Multicast Delegates

Console.WriteLine("Multicast Delegates:");

MulticastDelegate multicastDelegate = MethodOne;

multicastDelegate();

multicastDelegate += MethodTwo;

multicastDelegate();

multicastDelegate -= MethodTwo;

multicastDelegate();

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

static void MethodOne() => Console.WriteLine("Method 01");

static void MethodTwo() => Console.WriteLine("Method 02");

static float FuncMethod(int a, float b) => (a + b);

static void OnClompleteFunction(Action onComplete) => onComplete?.Invoke();

static void EmptyAction(int paramOne, float paramTwo) { };

delegate int DelegateMethod(int a, int b);

delegate void MulticastDelegate();