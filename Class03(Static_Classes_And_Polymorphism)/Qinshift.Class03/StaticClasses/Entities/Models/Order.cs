using StaticClasses.Entities.Enums;
using StaticClasses.Entities.Helpers;

namespace StaticClasses.Entities.Models
{
    public class Order : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public OrderStatus Status { get; set; }

        public Order(int id, string title, string description, OrderStatus status=OrderStatus.Processing) : base(id)
        {
            Title = title;
            Description = description;
            Status = status;
        }

        public string GetOrderInfo()
        {
            return $"{TextHelper.CapitalizeFirstLetter(Title)}-{Description}";
        }
    }
}
