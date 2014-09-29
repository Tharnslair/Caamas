using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YCM.BL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace YCM.BL
    {
        public class Order
        {
            public Order(){

            }

            public Order(int orderId)
            {
                this.OrderId = orderId;
            }

            public int CustomerId { get; set; }
            public int ShippingAddressId { get; set; }
            public DateTimeOffset? OrderDate { get; set; }
            public int OrderId { get; private set; }
            public List<OrderItem> orderItems { get; set; } 

            /// <summary>
            /// Retrieve one order.
            /// </summary>
            public Order Retrieve(int orderId)
            {
                // Code that retrieves the defined order
                return new Order();
            }

            /// <summary>
            /// Saves the current order.
            /// </summary>
            /// <returns></returns>
            public bool Save()
            {
                // Code that saves the defined order
                return true;
            }

            /// <summary>
            /// Validates the order data.
            /// </summary>
            /// <returns></returns>
            public bool Validate()
            {
                var isValid = true;

                if (OrderDate == null) isValid = false;

                return isValid;
            }
        }
    }

}
