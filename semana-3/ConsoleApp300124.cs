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
Console.WriteLine($"p | {p & p,-5} | {p & q,-5} ");
console.Writeline($"p | {q & p,-5} | {q & q,-5} ");
Console.Writeline();
Console.Writeline($"OR | p | q ");
Console.Writeline($"p | {p | p,-5} | {p | q,-5}");
console.Writeline($"q | {q | p,-5} | {q | q,-5}");
Console.Writeline();
Console.Writeline($"XOR | p | q ");
Console.Writeline($"p | {p ^ p,-5} | {p ^ q,-5} ");
Console.Writeline($"q | {q ^ p,-5} | {q ^ q,-5} ");
#endregion
#region 
Console.Writeline();
int x = 10;
int y = 6;
Console.WriteLine($"Expresion | Decimal | Binary");
Console.WriteLine($"------------------------------");
Console.WriteLine($"X | {X,7} | {X:B8}");
Console.Writeline($"y | {y,7} | {y:B8}");
Console.Writeline($"x & y | {x & y,7} | {x & y:B8}");
Console.WriteLine($"x | y | {x | y,7} | {x | y:B8}");
Console.WriteLine($"x ^ y | {x ^ y,7} | {x ^ y:B8}");
#endregion
