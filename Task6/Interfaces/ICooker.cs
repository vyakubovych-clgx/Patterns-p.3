using Task6.Enums;

namespace Task6.Interfaces;

public interface ICooker
{
    void FryRice(int amount, Level level);
    void FryChicken(int amount, Level level);
    void SaltRice(Level level);
    void SaltChicken(Level level);
    void PepperRice(Level level);
    void PepperChicken(Level level);
    void CookTea(Tea tea, int teaAmount, int honeyAmount);
}