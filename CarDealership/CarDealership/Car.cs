using System;

namespace CarDealership
{
    public class Car
    {
        public string Brand;
        public int YearOfRelease;
        public string Vin;
        public AllBodyTypes BodyType;
        public long Price;
        public DateTime DateOfSell;
        public string BuyerDetails;

        public Car(string brand, int yearOfRelease, string vin, AllBodyTypes bodyType, long price, string dateOfSell, string buyerDetails)
        {
            Brand = brand;
            YearOfRelease = yearOfRelease;
            Vin = vin;
            BodyType = bodyType;
            Price = price;
            DateOfSell = DateTime.Parse(dateOfSell);
            BuyerDetails = buyerDetails;
        }
        public override string ToString()
        {
            return $"Бренд: {Brand}. Год выпуска: {YearOfRelease}. Идентификационный номер: {Vin}.";
        }
        public void PrintInfo()
        {
            Console.WriteLine(this);

            var bodyType = "";
            switch (BodyType)
            {
                case AllBodyTypes.Cabriolet:
                    bodyType = "кабриолет";
                    break;
                case AllBodyTypes.Hatchback:
                    bodyType = "хэтчбек";
                    break;
                case AllBodyTypes.Sedan:
                    bodyType = "седан";
                    break;
                case AllBodyTypes.Station_wagon:
                    bodyType = "универсал";
                    break;
            }
            
            Console.WriteLine($"Тип кузова: {bodyType}. Цена: {Price}. Дата продажи: {DateOfSell.ToShortDateString()}. ФИО покупателя: {BuyerDetails}.");
        }
    }
}
