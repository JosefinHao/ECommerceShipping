using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceShipping.Model
{
    public class ShippingDateCalculator
    {

        public DateTime CalculateShippingDate(DateTime orderDate, Product product)
        {
            DateTime shipDate = orderDate;
            int maxDaysToShip = product.MaxBusinessDaysToShip - 1;
            bool shipOnWeekends = product.ShipOnWeekends;
            string? manufacturer = product.Manufacturer;

            while (maxDaysToShip > 0)
            {
                shipDate = shipDate.AddDays(1);

                if (!shipOnWeekends && (shipDate.DayOfWeek == DayOfWeek.Saturday || shipDate.DayOfWeek == DayOfWeek.Sunday))
                {
                    continue;
                }

                if (Holidays.IsHoliday(shipDate, manufacturer))
                {
                    continue;
                }

                maxDaysToShip--;
            }

            return shipDate;
        }


    }
}
