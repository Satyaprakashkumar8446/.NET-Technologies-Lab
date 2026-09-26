using System;
namespace
ExpenseTrackingModule
{
class Expense
{
private string expenseName;
private double amount;
private string category;
public Expense(string name,
double amt, string cat)
{
expenseName = name;
amount = amt;
category = cat;
}
public void DisplayExpense()
{
Console.WriteLine("\n==========
Expense Details ==========");
Console.WriteLine("ExpenseName : " + expenseName);
Console.WriteLine("Category
: " + category);
Console.WriteLine("Amount
: ₹" + amount);
}
}
class Program
{
static void Main(string[] args)
{
Console.WriteLine("============
===========================
===");
Console.WriteLine("
Expense Tracking Module");
Console.WriteLine("============
===========================
===");
Console.WriteLine("Name
: Satyaprakash Kumar");
Console.WriteLine("Enrollment No
: 92400103551");
Console.WriteLine();
try
{
Console.Write("Enter
Expense Name : ");
string name =
Console.ReadLine();
Console.Write("Enter
Expense Category : ");
string category =
Console.ReadLine();
Console.Write("Enter
Expense Amount : ");
double amount =
Convert.ToDouble(Console.ReadLin
e());
if (amount <= 0)
{
throw new
Exception("Expense amount must
be greater than zero.");
}
Expense exp = new
Expense(name, amount, category);
exp.DisplayExpense();
Console.WriteLine("\nExpense
recorded successfully.");
}
catch (FormatException)
{
Console.WriteLine("\nError: Please
enter a valid numeric amount.");
}
catch (Exception ex)
{
Console.WriteLine("\nException: "
+ ex.Message);
}
finally
{
Console.WriteLine("\nThank you
for using the Expense Tracking
Module.");
}
Console.WriteLine("\nPress
any key to exit...");
Console.ReadKey();
            }
       }
    }                  
