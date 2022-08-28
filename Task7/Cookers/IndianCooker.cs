namespace Task7.Cookers;

public class IndianCooker : Cooker
{
    protected override void FryRice()
    {
        Console.WriteLine("Strongly fried 200 grams of rice.");
    }

    protected override void FryChicken()
    {
        Console.WriteLine("Strongly fried 100 grams of chicken.");
    }

    protected override void SaltRice()
    {
        Console.WriteLine("Strongly salted the rice.");
    }

    protected override void SaltChicken()
    {
        Console.WriteLine("Strongly salted the chicken.");
    }

    protected override void PepperRice()
    {
        Console.WriteLine("Strongly peppered the rice.");
    }

    protected override void PepperChicken()
    {
        Console.WriteLine("Strongly peppered the chicken.");
    }

    protected override void CookTea()
    {
        Console.WriteLine("Cooked 15 grams of green tea with 12 grams of honey.");
    }
}