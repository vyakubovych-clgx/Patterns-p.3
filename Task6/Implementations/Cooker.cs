﻿using Task6.Enums;
using Task6.Interfaces;

namespace Task6.Implementations;

public class Cooker : ICooker
{
    public void FryRice(int amount, Level level)
    {
        Console.WriteLine($"{level} fried {amount} grams of rice.");
    }

    public void FryChicken(int amount, Level level)
    {
        Console.WriteLine($"{level} fried {amount} grams of chicken.");
    }

    public void SaltRice(Level level)
    {
        Console.WriteLine($"{level} salted the rice.");
    }

    public void SaltChicken(Level level)
    {
        Console.WriteLine($"{level} salted the chicken.");
    }

    public void PepperRice(Level level)
    {
        Console.WriteLine($"{level} peppered the rice.");
    }

    public void PepperChicken(Level level)
    {
        Console.WriteLine($"{level} peppered the chicken.");
    }

    public void CookTea(Tea tea, int teaAmount, int honeyAmount)
    {
        Console.WriteLine($"Cooked {teaAmount} grams of {tea} tea with {honeyAmount} grams of honey.");
    }
}