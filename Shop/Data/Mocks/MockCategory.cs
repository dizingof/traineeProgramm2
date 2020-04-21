using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryName = "ElektroCars", Description = "Elekto transport"},
                    new Category{CategoryName = "Classik cars", Description = "Avto s dvigatelem vnutrenego sgoraniya"},

                };
            }
        }
    }
}
