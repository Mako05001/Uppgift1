Console.Write("Tors tid ?");
double T = double.Parse(Console.ReadLine());
Console.Write("Mors tid ?");
double M = double.Parse(Console.ReadLine());
double m = 40;
double k = 0;
double v = 0;
double l = 1 / T;
double r = 1 / M;

while (k + v < m)
{
    k = k + l;

    v = v + r;
}


int L = (int)Math.Round(k);
int V = (int)Math.Round(v);
if (L + V == 41)
{
    L--;
    V--;
}
Console.Write("Svar: Tor:" + L + "  ");
Console.Write("Mor:" + V);





