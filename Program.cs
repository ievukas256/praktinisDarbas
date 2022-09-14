/*1. suskaiciuoti rutulio plota spindulys 6371km, rezult rasyti i kintamaji 4pi *r*r
2. suskaiciuoti turi 6371km, rez i kintamaji 4/3 pi*r*r*r
3. suskaiciuoti staciojo trikampio izambines(pries statuji kampa esanti staciojo trikampio krastine) ilgi 
   jei kitu krastiniu ilgiai yra 10 ir 15, rez i kintamaji
4. suskaiciuoti uzduotyse 1-3 gautu kintamuju suma ir vidurki , isvesti rez kaip pavyzdi*/


//1.---//2.--- Žemės rutulio plotas ---- 
double r = 6371;
double area = 4 * Math.PI * r * r;

//2.--- Žemės rutulio tūris ----  
double v = (4 * Math.PI * r * r * r) / 3;

//3.----izambines ilgis----
int a1 = 10;
int b1 = 15;
var rez = Math.Sqrt((a1 * a1) + (b1 * b1));

//4. -----Kintamųjų suma ir vidurkis. -------
double sum = area + v + rez;
double average = sum / 3;
Console.WriteLine("**********************************");
Console.WriteLine("* Viso kintamųjų: 3");
Console.WriteLine("* Kintamasis1: {0:0.00}", area);
Console.WriteLine("* Kintamasis2: {0:0.00}", v);
Console.WriteLine("* Kintamasis3: {0:0.00}", rez);
Console.WriteLine("* Suma: {0:0.00}", sum);
Console.WriteLine("* Vidurkis: {0:0.00}", average);
Console.WriteLine("**********************************");