double greenArea = double.Parse(Console.ReadLine());

double pricePerSquareMeter = 7.61;
double finalPrice = greenArea * pricePerSquareMeter;
double discount = finalPrice * 0.18;
double priceWithDiscount = finalPrice - discount;

Console.WriteLine($"The final price is: {priceWithDiscount:F2} lv.");
Console.WriteLine($"The discount is: {discount:F2} lv.");