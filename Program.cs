/*1. suskaiciuoti rutulio plota spindulys 6371km, rezult rasyti i kintamaji
2. suskaiciuoti turi 6371km, rez i kintamaji
3. suskaiciuoti staciojo trikampio izambines(pries statuji kampa esanti staciojo trikampio krastine) ilgi 
   jei kitu krastiniu ilgiai yra 10 ir 15, rez i kintamaji
4. suskaiciuoti uzduotyse 1-3 gautu kintamuju suma ir vidurki , isvesti rez kaip pavyzdi*/

int r = 6371;
double pi = 3.14;
int a  = 10;
int b = 15;

double S = 4 * pi * r *r;
Console.WriteLine("Žemės rutulio plotas: {0:0.00}", S);
double V = (4 * pi * r * r * r)/3;
Console.WriteLine("Žemės rutulio tūris: {0:0.00}", V);
double c = Math.Sqrt(a * a + b * b);
Console.WriteLine("Trikampio įžambinės ilgis: {0:0.00}", c);

