/*1. suskaiciuoti rutulio plota spindulys 6371km, rezult rasyti i kintamaji 4pi *r*r
2. suskaiciuoti turi 6371km, rez i kintamaji 4/3 pi*r*r*r
3. suskaiciuoti staciojo trikampio izambines(pries statuji kampa esanti staciojo trikampio krastine) ilgi 
   jei kitu krastiniu ilgiai yra 10 ir 15, rez i kintamaji
4. suskaiciuoti uzduotyse 1-3 gautu kintamuju suma ir vidurki , isvesti rez kaip pavyzdi*/




















//3.----izambines ilgis----
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
int a1 = 10;
int b1 = 15;
var c1 = Math.Sqrt((a1 * a1) + (b1 * b1));
Console.WriteLine($"Kintamasis 3: {c1}");