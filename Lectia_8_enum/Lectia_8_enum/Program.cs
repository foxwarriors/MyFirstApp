using System;

namespace Lectia_8_enum
{
	public class Program
	{
		public static void Main()
		{
			BurgerOrder o1 = new BurgerOrder() { burgerName = "Veggie", Amount = 1, Cooking = BurgerCooking.Rare };
			BurgerOrder o2 = new BurgerOrder() { burgerName = "Beef", Amount = 2, Cooking = BurgerCooking.Medium };

			Console.WriteLine(o1.Cooking);
			Console.WriteLine(o2.Cooking);

		}
	}
}

public enum BurgerCooking
{
	Rare,
	Medium,
	WellDone
}

public class BurgerOrder
{
	public string burgerName;
	public int Amount;
	public BurgerCooking Cooking;
}
