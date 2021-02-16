using System;
using Entities.Abstract;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car : ICar
    {
        public int Id { get; set; }
        public int BrandID { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }


    }
}
