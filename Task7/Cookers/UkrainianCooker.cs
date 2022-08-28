namespace Task7.Cookers;

public class UkrainianCooker : Cooker
{
    protected override void FryRice()
    {
        Console.WriteLine("Strongly fried 500 grams of rice.");
    }

    protected override void FryChicken()
    {
        Console.WriteLine("Medium fried 300 grams of chicken.");
    }

    protected override void SaltRice()
    {
        Console.WriteLine("Strongly salted the rice.");
    }

    protected override void SaltChicken()
    {
        Console.WriteLine("Medium salted the chicken.");
    }

    protected override void PepperRice()
    {
        Console.WriteLine("Low peppered the rice.");
    }

    protected override void PepperChicken()
    {
        Console.WriteLine("Low peppered the chicken.");
    }

    protected override void CookTea()
    {
        Console.WriteLine("Cooked 10 grams of black tea with 10 grams of honey.");
    }
}