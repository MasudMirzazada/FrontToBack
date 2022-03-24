using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurboASP.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int BrandId { get; set; }
        public Brand Brand   { get; set; }
    }
}
