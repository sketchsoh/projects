using System;
using System.Collections.Generic;
using System.Text;


partial class Program
{

    public static void PrintSleepingBagType(SleepingBagType type)
    {
        switch (type)
        {
            case SleepingBagType.SUMMER_SYNTHETIC:
                Console.WriteLine("Summer Synthetic Bag");
                break;
            case SleepingBagType.SUMMER_DOWN:
                Console.WriteLine("Summer Down Bag");
                break;
            case SleepingBagType.THREE_SEASON_SYNTHETIC:
                Console.WriteLine("Three Season Synthetic Bag");
                break;
            case SleepingBagType.THREE_SEASON_DOWN:
                Console.WriteLine("Three Season Down Bag");
                break;
            case SleepingBagType.WINTER_SYNTHETIC:
                Console.WriteLine("Winter Synthetic Bag");
                break;
            case SleepingBagType.WINTER_DOWN:
                Console.WriteLine("Winter Down Bag");
                break;
        }
    }
    public static SleepingBagType ChooseSleepingBag(int temperature, int humidity)
    {

        if (humidity >= 40)
        {
            if (temperature < 15)
            {
                return SleepingBagType.WINTER_SYNTHETIC;
            }
            else if (temperature >= 15 && temperature < 30)
            {
                return SleepingBagType.THREE_SEASON_SYNTHETIC;
            }
            else
            {
                return SleepingBagType.SUMMER_SYNTHETIC;
            }
        }
        else
        {
            if (temperature < 15)
            {
                return SleepingBagType.WINTER_DOWN;
            }
            else if (temperature >= 15 && temperature < 30)
            {
                return SleepingBagType.THREE_SEASON_DOWN;
            }
            else
            {
                return SleepingBagType.SUMMER_DOWN;
            }
        }
    }

    public static int Calculate(int lhs, int rhs, OperationType op)
    {
        int result = 0;
        switch (op)
        {
            case OperationType.ADD:
                result = lhs + rhs;
                break;
            case OperationType.SUBTRACT:
                result = lhs - rhs;
                break;
            case OperationType.MULTIPLY:
                result = lhs * rhs;
                break;
            default:
                break;
        }
        return result;
    }
}
