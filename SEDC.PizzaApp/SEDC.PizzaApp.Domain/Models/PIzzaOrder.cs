using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.Domain.Models
{
    public class PIzzaOrder
    {
        public int Id { get; set; }
        public int Order { get; set; }
        public int PizzaId { get; set; }
    }
}
