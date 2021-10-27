using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.PizzaApp.DataAccess.Repositories.EFEntityRepositories
{
    public class PizzaEFEntityRepository : IRepository<Pizza>
    {
        private PizzaDbContext _pizzaDbContext;

        public PizzaEFEntityRepository(PizzaDbContext pizzaDbContext)
        {
            _pizzaDbContext = pizzaDbContext;
        }
        public List<Pizza> GetAll()
        {
            return StaticDb.Pizzas.ToList();
        }

        public Pizza GetById(int id)
        {
            return StaticDb.Pizzas.FirstOrDefault(q => q.Id.Equals(id));
        }

        public int Insert(Pizza entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Pizza entity)
        {
            throw new NotImplementedException();
        }
        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
