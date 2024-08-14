using System;

namespace TaskJunior6
{
    class Program
    {
        static void Main(string[] args)
        {
            int crystals;
            int money;
            int pricePerCrystal = 25;
            bool isAbleToPay;

            Console.WriteLine("Приветствую тебя, странник, в нашем большом МАГАЗИНЕ Кристаллов\nЗдесь ты можешь покупать различные кристаллы со всего мира и не только....");
            Console.WriteLine($"Сегодня и только сейчас, именно для тебя, странник, ВСЕ кристаллы будут стоить по {pricePerCrystal} золота");
            Console.Write("Сколько у вас золота: ");
            money = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько вам нужно кристаллов: ");
            crystals = Convert.ToInt32(Console.ReadLine());

            isAbleToPay = money >= crystals * pricePerCrystal;
            crystals *= Convert.ToInt32(isAbleToPay);
            money -= crystals * pricePerCrystal;

            Console.WriteLine($"У вас в рукзаке {crystals} единицы кристаллов и {money} золота");
        }
    }
}
