using Task7;
using Task7.Cookers;

var ukrainianCooker = new UkrainianCooker();
var indianCooker = new IndianCooker();
var restaurant = new Restaurant();
restaurant.CookMasala(ukrainianCooker);
Console.WriteLine();
restaurant.CookMasala(indianCooker);
Console.ReadLine();