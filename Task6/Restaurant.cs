using Task6.Enums;
using Task6.Interfaces;

namespace Task6;

public class Restaurant
{
    public void CookMasala(ICooker cooker, Country country)
    {
        switch (country)
        {
            case Country.Ukraine:
                cooker.FryRice(500, Level.Strongly);
                cooker.SaltRice(Level.Strongly);
                cooker.PepperRice(Level.Low);
                cooker.FryChicken(300, Level.Medium);
                cooker.SaltChicken(Level.Medium);
                cooker.PepperChicken(Level.Low);
                cooker.CookTea(Tea.Black, 10, 10);
                break;
            case Country.India:
                cooker.FryRice(200, Level.Strongly);
                cooker.SaltRice(Level.Strongly);
                cooker.PepperRice(Level.Strongly);
                cooker.FryChicken(100, Level.Strongly);
                cooker.SaltChicken(Level.Strongly);
                cooker.PepperChicken(Level.Strongly);
                cooker.CookTea(Tea.Green, 15, 12);
                break;
            default:
                throw new ArgumentException("Unsupported country.", nameof(country));
        }
    }
}