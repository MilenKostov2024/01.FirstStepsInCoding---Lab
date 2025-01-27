int dogfood = int.Parse(Console.ReadLine());
int catfood = int.Parse(Console.ReadLine());

double dogsum = dogfood * 2.5;
double catsum = catfood * 4;

double sum = dogsum + catsum;

Console.WriteLine($"{sum} lv.");