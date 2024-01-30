// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

int a = 3;
int b = a++;
Console.WriteLine($"a is {a}, b is {b}");
#region Exploring unary operators
int c = 3;
int d = ++c;
// Prefix means increment c before assignig it.
Console.WriteLine($"c is {c}), d is {d}");
#endregion
#region
int e = 11;
int f = 3;
Console.WriteLine($"e is {e}, f is´{f}");
Console.WriteLine($"e + f = {e + f}");
Console.WriteLine($"e - f = {e - f}");
Console.WriteLine($"e e * f = {e * f}");
Console.WriteLine($"e e / f = {e % f}");
Console.WriteLine($"e e % f = {e % f}");
double g = 11.0;
Console.WriteLine($"g is {g:N1}, f is {f}");
Console.WriteLine($"g / f = {g / f}");
#endregion
#region
int p = 6;
p += 3; // Equivalent to: p = p + 3;
p -= 3;
p *= 3;
p /= 3;
#endregion
#region
string? authorName = Readline();
int maxLength = authorName.Length ?? 30;
authorName ??= "unknown";
#endregion
#region
bool p = true;
bool q = false;
Console.WriteLine($"AND | p | q ");
