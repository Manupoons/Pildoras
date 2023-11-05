
//Console.WriteLine("Hello, World!");

/*
string Friend = "Manu";
Console.WriteLine("Hello "+Friend);
Console.WriteLine($"Hello {Friend}");
*/

/*
string Friend1 = "Manu";
string Friend2 = "Sergio";
Console.WriteLine($"Hello {Friend1} and {Friend2}");
Console.WriteLine($"The name: {Friend1} has {Friend1.Length} letters");
Console.WriteLine($"The name: {Friend2} has {Friend2.Length} letters");
*/

/*
string greeting = "         Hello World         ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"Trimmed start: [{trimmedGreeting}]");


trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"Trimmed end: [{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"Trimmed: [{trimmedGreeting}]");
*/

/*
string sayHello = "Hello World";
Console.WriteLine(sayHello);

sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());
*/

/*
string songLyrics = "You say goodbye, and I say hello";

var result = songLyrics.StartsWith("You");
Console.WriteLine(result);
Console.WriteLine(songLyrics.Contains("greetings"));
*/

/*
int a = 1;
int b = 6;
int c = 2;
int c1 = a + b;
int c2 = a - b;
int c3 = a * b;
int c4 = a / b;
int c5 = a + b * a;
int c6 = (a + b) * a;
int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;

Console.WriteLine(c1);
Console.WriteLine(c2);
Console.WriteLine(c3);
Console.WriteLine(c4);
Console.WriteLine(c5);
Console.WriteLine(c6);
Console.WriteLine(d);
*/

/*
int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");
*/

/*
int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

int what = max+3;
Console.WriteLine($"An example of overflow: {what}");
*/

/*
double a = 5;
double b = 4;
double c = 2;
double d = (a + b) / c;
Console.WriteLine(d);
*/

/*
double a = 19;
double b = 23;
double c = 8;
double d = (a + b) / c;
Console.WriteLine(d);
*/

/*
double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"The range of double is {min} to {max}");

double third = 1.0 / 3.0;
Console.WriteLine(third);
*/

/*
decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min} to {max}");

double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);
*/

/*
decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min} to {max}");

int max2 = int.MaxValue;
int min2 = int.MinValue;
Console.WriteLine($"The range of integers is {min2} to {max2}");

long min3 = long.MinValue;
long max3 = long.MaxValue;
Console.WriteLine($"The range of the long type is {min3} to {max3}");

short min4 = short.MinValue;
short max4 = short.MaxValue;
Console.WriteLine($"The range of the short type is {min4} to {max4}");

double radius = 2.50;
double area = Math.PI * radius * radius;
Console.WriteLine(area);
*/

/*
int a = 5;
int b = 6;
bool something = a + b > 10; 
if (something)
{
    Console.WriteLine("The answer is greater than 10");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
}
*/

/*
int a = 5;
int b = 5;
int c = 4;
if ((a + b + c >10) && (a == b))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("Or the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("And the first number is not equal to the second");
}
*/

/*
int a = 5;
int b = 6;
int c = 4;
if ((a + b + c >10) || (a == b))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("And the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("Or the first number is not equal to the second");
}
*/

/*
int counter = 0;
while (counter < 10)
{
    Console.WriteLine($"Hello world The counter is {counter}");
    counter++;
}

int counter2 = 20;
do
{
    Console.WriteLine($"Hello world The counter is {counter2}");
    counter2++;
}while (counter2 < 10);

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Hello World The index is {i}");
    
}
*/

/*
int sum=0;
for (int i = 1; i <= 20; i++)
{
    if (i % 3 == 0)
    {
        sum = sum + i;
    }
}

Console.WriteLine($"The sum is: {sum}");
*/

/*
var names = new List<string> {"<name>", "Ana", "Felipe"};
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

for (int i = 0; i<names.Count; i++)
{
    Console.WriteLine($"Hello {names[i].ToUpper()}!");
}

names.Add("Maria");
names.Add("Bill");
names.Remove("Ana");
foreach (var name in names)
{
    Console.WriteLine(name);    
}

var index = names.IndexOf("Ana");
if (index == -1)
{
    Console.WriteLine($"Not found");
}
else
{
    Console.WriteLine($"Found Felipe at {index}");
}


var names = new List<string> {"Manu", "Ana", "Felipe"};
names.Add("Maria");
names.Add("Bill");

names.Sort();
foreach (var name in names)
{
    Console.WriteLine(name);    
}
*/

/*
var fibonacci = new List<int> { 1, 1 };

while (fibonacci.Count < 20)
{
    var previous = fibonacci[fibonacci.Count - 1];
    var previous2 = fibonacci[fibonacci.Count - 2];

    fibonacci.Add(previous + previous2);
}

foreach (var item in fibonacci)
{
    Console.WriteLine(item);
}
*/

/*
using System.Text;

class BankAccount
{
    public string Number { get; }
    public string Owner { get; set; }

    public decimal Balance
    {
        get
        {
            decimal balance = 0;
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
            }
            return balance;
        }
    }

    private static int accountNumberSeed = 1234567890;

    private List<Transaction> allTransactions = new List<Transaction>();
    public BankAccount(string name, decimal initialBalance)
    {
        Owner = name;
        MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
        Number = accountNumberSeed.ToString();
        accountNumberSeed++;
    }
    
    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
        }

        var deposit = new Transaction(amount, date, note);
        allTransactions.Add(deposit);
    }
    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
        }
        if (Balance - amount < 0)
        {
            throw new InvalidOperationException("Not sufficient funds for this withdrawal");
        }
        var withdrawal = new Transaction(-amount, date, note);
        allTransactions.Add(withdrawal);
    }

    public string GetAccountHistory()
    {
        var report = new StringBuilder();

        report.AppendLine("Date\t\tAmmount\tNote");
        foreach (var item in allTransactions)
        {
            report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}$\t{item.Notes}");
        }

        return report.ToString();
    }
}

public class Transaction
{
    public decimal Amount { get; }
    public DateTime Date { get; }
    public string Notes { get; }
    
    public Transaction(decimal amount, DateTime date, string note)
    {
        Amount = amount;
        Date = date;
        Notes = note;
    }
}
*/

/*
List<int> numbers = new List<int>(){5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

var lowNums = from num in numbers where num < 5 select num;

Console.WriteLine("Numbers < 5");
foreach (var x in lowNums)
{
    Console.WriteLine(x);
}
*/

/*
List<Product> products = GetProductList();

var soldOutProducts = from prod in products where prod.UnitsInStock = 0 select prod;

Console.WriteLine("Sold out products: ");
foreach (var product in soldOutProducts)
{
    Console.WriteLine($"{product.ProductName} is sold out");
}
*/

/*
string[] digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

var shortDigits = digits.Where((digit, index) => digit.Length < index);

Console.WriteLine("Short digits:");
foreach (var d in shortDigits)
{
    Console.WriteLine($"The word {d} is shorter than its value");
}
*/

/*
int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

var first3numbers = numbers.Take(3);

Console.WriteLine("First 3 numbers:");
foreach (var n in first3numbers)
{
    Console.WriteLine(n);
}
*/

/*
List<Customer> customers = GetCustomerList();

var first3WAOrders = (
    from cust in customers
    from order in cust.Orders
    where customers.Region == "WA"
    select (cust.CustomerID, order.OrderID, order.OrderDate)).Take(3);

Console.WriteLine("First 3 orders in WA");
foreach (var order in first3WAOrders)
{
    Console.WriteLine(order);
}
*/

/*
var wordsA = new string[] {"cherry", "apple", "blueberry"};
var wordsB = new string[] {"cherry", "apple", "blueberry"};

bool match = wordsA.SequenceEqual(wordsB);

Console.WriteLine($"The sequences match: {match}");
*/

/*
int[] vectorA = {0, 2, 4, 5, 6};
int[] vectorB = {1, 3, 5, 7, 8};

int dotProduct = vectorA.Zip(vectorB, (a, b) => a * b).Sum();

Console.WriteLine($"Dot product: {dotProduct}");
*/

/*
int[] numbersA = {0, 2, 4, 5, 6, 8, 9};
int[] numbersB = {1, 3, 5, 7, 8};

var pairs = from a in numbersA
            from b in numbersB
            where a < b
            select  (a, b);

Console.WriteLine("Pairs whera a < b");
foreach (var pair in pairs)
{
    Console.WriteLine($"{pair.a} is less than {pair.b}");
}           
*/

/*
int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

int i = 0;
var q = (from n in numbers
                    select ++i);

foreach (var v in q)
{
    Console.WriteLine($"v = {v}, i = {i}");
}                  
*/

/*
int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

int i = 0;
var q = (from n in numbers
                select ++i)
                .ToList();

foreach (var v in q)
{
    Console.WriteLine($"v = {v}, i = {i}");
}           
*/


int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
var lowNumbers = from n in numbers 
                                where n <= 3 
                                select n;

Console.WriteLine("First run numbers <= 3:");
foreach (int n in lowNumbers)
{
    Console.WriteLine(n);
}

for (int i = 0; i < 10; i++)
{
    numbers[i] = -numbers[i];
}

Console.WriteLine("Second run numbers <= 3:");
foreach (int n in lowNumbers)
{
    Console.WriteLine(n);
}
