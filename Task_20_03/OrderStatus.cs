using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_03
{
    public enum OrderStatus
    {
        New,
        Processing,
        Shipped,
        Delivered,
        Cancelled
    }
    public class Order
    {
        public OrderStatus Status { get; private set; } = OrderStatus.New;

        public void ChangeStatus(OrderStatus newStatus)
        {
            if (Status == OrderStatus.Delivered || Status == OrderStatus.Cancelled)
            {
                Console.WriteLine("Невозможно изменить статус: заказ уже доставлен или отменён.");
                return;
            }

            Status = newStatus;
            Console.WriteLine($"Заказ переведён в статус: {Status}");
        }
    }
}
