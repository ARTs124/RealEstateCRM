using System;

namespace RealEstateCRM
{
    /// <summary>Вимоги клієнта із заявки. 0 або "" означає «критерій не вказано».</summary>
    public class ClientRequest
    {
        public string PropertyType;
        public decimal MinArea;
        public decimal MaxArea;
        public decimal MinBudget;
        public decimal MaxBudget;
        public string District;
        public int Rooms;
    }

    /// <summary>Об'єкт нерухомості, який порівнюється із заявкою.</summary>
    public class PropertyItem
    {
        public int Id;
        public string Title;
        public string Type;
        public decimal Price;
        public decimal Area;
        public string District;
        public int Rooms;
    }

    /// <summary>
    /// Алгоритм автоматичного підбору нерухомості (Matching).
    /// За кожен критерій, що збігся, нараховуються бали:
    /// бюджет — 40, площа — 25, район — 20, кількість кімнат — 15 (разом 100).
    /// Якщо критерій у заявці не вказано, він не враховується,
    /// а відсоток рахується від суми балів критеріїв, що залишилися.
    /// </summary>
    public static class Matcher
    {
        public const int BudgetPoints = 40;
        public const int AreaPoints = 25;
        public const int DistrictPoints = 20;
        public const int RoomsPoints = 15;

        /// <summary>Повертає відсоток збігу від 0 до 100.</summary>
        public static int CalculateMatch(ClientRequest request, PropertyItem property)
        {
            // Тип нерухомості — обов'язкова умова: квартира не підходить тому, хто шукає будинок
            if (request.PropertyType != "" && request.PropertyType != property.Type)
                return 0;

            int maxPoints = 0;   // скільки балів можна було набрати
            int points = 0;      // скільки балів набрав об'єкт

            // 1. Бюджет: ціна має бути в межах від MinBudget до MaxBudget
            if (request.MinBudget > 0 || request.MaxBudget > 0)
            {
                maxPoints += BudgetPoints;
                if (IsInRange(property.Price, request.MinBudget, request.MaxBudget))
                    points += BudgetPoints;
            }

            // 2. Площа: від MinArea до MaxArea
            if (request.MinArea > 0 || request.MaxArea > 0)
            {
                maxPoints += AreaPoints;
                if (IsInRange(property.Area, request.MinArea, request.MaxArea))
                    points += AreaPoints;
            }

            // 3. Район має збігатися
            if (request.District != "")
            {
                maxPoints += DistrictPoints;
                if (request.District == property.District)
                    points += DistrictPoints;
            }

            // 4. Кількість кімнат має збігатися
            if (request.Rooms > 0)
            {
                maxPoints += RoomsPoints;
                if (request.Rooms == property.Rooms)
                    points += RoomsPoints;
            }

            // Якщо в заявці не вказано жодного критерію — підходить будь-який об'єкт потрібного типу
            if (maxPoints == 0)
                return 100;

            // Відсоток від максимально можливих балів
            return (int)Math.Round(points * 100.0 / maxPoints);
        }

        /// <summary>Перевіряє, чи входить значення в діапазон. Межа 0 означає «без обмеження».</summary>
        private static bool IsInRange(decimal value, decimal min, decimal max)
        {
            if (min > 0 && value < min) return false;
            if (max > 0 && value > max) return false;
            return true;
        }
    }
}
