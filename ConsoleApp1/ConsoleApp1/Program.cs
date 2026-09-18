#region Q01

using System.Text;

string title = "clean code";
string upperTitle = title.ToUpper();

Console.WriteLine(title);       
Console.WriteLine(upperTitle);

#endregion

#region Q2

string title1 = "Clean Code";
string title2 = "Clean Code";

Console.WriteLine(ReferenceEquals(title1, title2));
#endregion

#region Q3

StringBuilder sb = new StringBuilder();
sb.Append("Book List");
sb.Append(" - updates");

Console.WriteLine(sb.ToString());

#endregion

#region Q4

sb.Replace("Book List", "Library");

Console.WriteLine(sb.ToString());

#endregion

#region Q5

string title02 = "Clean Code";
int pages = 464;

string result = "Book: " + title02 + ", Pages: " + pages;
Console.WriteLine(result);

#endregion

#region Q6

string result02 = $"Book: {title02}, Pages: {pages}";
Console.WriteLine(result02);

#endregion

#region Q7

string result03 = string.Format("Book: {0}, Pages: {1}", title, pages);
Console.WriteLine(result03);

#endregion

#region Q8

int a = 464;

if (a > 200)
{
    Console.WriteLine("Long Book");
}
else
{
    Console.WriteLine("Short Book");
}
#endregion

#region Q9

int v = 464;
bool isAvailable = false;

if (v > 300 && isAvailable)
{
    Console.WriteLine("You can borrow this book");
}
#endregion