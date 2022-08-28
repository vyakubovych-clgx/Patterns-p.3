namespace Task7.Cookers;

public abstract class Cooker
{
    public void CookMasala()
    {
        FryRice();
        SaltRice();
        PepperRice();
        FryChicken();
        SaltChicken();
        PepperChicken();
        CookTea();
    }

    protected virtual void FryRice()
    {
        Console.WriteLine("Fried a single rice grain until it became black.");
    }

    protected virtual void FryChicken()
    {
        Console.WriteLine("Grabbed a living chicken, put it onto the pan and fried it to death.");
    }

    protected virtual void SaltRice()
    {
        Console.WriteLine("Emptied an entire box of salt onto the rice.");
    }

    protected virtual void SaltChicken()
    {
        Console.WriteLine("Forced a chicken to eat all the salt.");
    }

    protected virtual void PepperRice()
    {
        Console.WriteLine("Put a little bit of rice into a bag of pepper.");
    }

    protected virtual void PepperChicken()
    {
        Console.WriteLine("Threw some pepper into chicken's eyes.");
    }

    protected virtual void CookTea()
    {
        Console.WriteLine("Poured some beer instead.");
    }
}