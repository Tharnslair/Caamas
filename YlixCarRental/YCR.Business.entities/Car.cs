using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace YCR.Business.entities
{
    [DataContract]
    public class Car
    {
        [DataMember]
        public int CarId { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Color { get; set; }

        [DataMember]
        public int Year { get; set; }

        [DataMember]
        public decimal RentalPrice { get; set; }

        [DataMember]
        public bool CurrentlyRented { get; set; }
    }
}
