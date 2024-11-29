using System;


partial class Program
{
    public enum SleepingBagType
    {
        SUMMER_SYNTHETIC,
        SUMMER_DOWN,

        THREE_SEASON_SYNTHETIC,
        THREE_SEASON_DOWN,

        WINTER_SYNTHETIC,
        WINTER_DOWN
    }

    public enum OperationType
    {
        ADD,
        SUBTRACT,
        MULTIPLY,
    }

	public static void TestPrintSleepingBagType() {
		Console.WriteLine("=== Test PrintSleepingBagType() ===");
		PrintSleepingBagType(SleepingBagType.SUMMER_SYNTHETIC);
        PrintSleepingBagType(SleepingBagType.SUMMER_DOWN);
        PrintSleepingBagType(SleepingBagType.THREE_SEASON_SYNTHETIC);
        PrintSleepingBagType(SleepingBagType.THREE_SEASON_DOWN);
        PrintSleepingBagType(SleepingBagType.WINTER_SYNTHETIC);
        PrintSleepingBagType(SleepingBagType.WINTER_DOWN);
	}
	
	
	public static void TestChooseSleepingBag()
    {
        Console.WriteLine("=== Test ChooseSleepingBag() ===");
        for (int temperature = 10; temperature <= 50; temperature += 10)
        {
            for (int humidity = 10; humidity <= 50; humidity += 10)
            {
                PrintSleepingBagType(ChooseSleepingBag(temperature, humidity));
            }
        }
    }

    public static void TestCalculate()
    {
        Console.WriteLine("=== Test Calculate() ===");
        for (int i = 0; i < 5; ++i)
        {
            for (int j = 0; j < 5; ++j)
            {
                Console.WriteLine("{0} + {1} = {2}", i, j, Calculate(i, j, OperationType.ADD));
                Console.WriteLine("{0} - {1} = {2}", i, j, Calculate(i, j, OperationType.SUBTRACT));
                Console.WriteLine("{0} * {1} = {2}", i, j, Calculate(i, j, OperationType.MULTIPLY));
            }
        }
    }

    public static void Main(string[] args)
    {
        TestPrintSleepingBagType();
		TestChooseSleepingBag();
		TestCalculate();
    }
}

