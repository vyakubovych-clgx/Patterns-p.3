using Task6;
using Task6.Enums;
using Task6.Implementations;

var cooker = new Cooker();
var restaurant = new Restaurant();
restaurant.CookMasala(cooker, Country.Ukraine);
Console.WriteLine();
restaurant.CookMasala(cooker, Country.India);
Console.ReadLine();