using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
           
                
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));
            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        Name = "Tesla Model S",
                        ShortDescription = "bistrii avtomobil",
                        LongDescriprion = "Tihii i bistrii avtomobil Tesla company",
                        Img = "/img/tesla.jpg",
                        Price = 45000,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["ElektroCars"]
                    },
                    new Car
                    {
                        Name = "Ford Fiesta",
                        ShortDescription = "Tihii i spokoinii",
                        LongDescriprion = "Udobnii avtomobil dlya goroda",
                        Img = "/img/fiesta.jpg",
                        Price = 11000,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Classik cars"]
                    },
                    new Car
                    {
                        Name = "BMW M3",
                        ShortDescription = "Race and style",
                        LongDescriprion = "Udobnii avtomobil dlya goroda",
                        Img = "/img/m3.jpg",
                        Price = 65000,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Classik cars"]
                    },
                     new Car
                     {
                         Name = "Mercedes C Class",
                         ShortDescription = "Uiutniu i bolshoi",
                         LongDescriprion = "Udobnii avtomobil dlya goroda",
                         Img = "/img/mercedes.jpg",
                         Price = 40000,
                         IsFavourite = true,
                         Available = true,
                         Category = Categories["Classik cars"]
                     },
                     new Car
                     {
                         Name = "Nissan Leaf",
                         ShortDescription = "besshumnii i ekonomichnii",
                         LongDescriprion = "Udobnii avtomobil dlya goroda",
                         Img = "/img/nissan.jpg",
                         Price = 14000,
                         IsFavourite = true,
                         Available = true,
                         Category = Categories["ElektroCars"]
                     }
                    );
            }
            content.SaveChanges();
        }


        public static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                    if(category == null)
                    {
                         var list = new Category[]
                         {
                            new Category{CategoryName = "ElektroCars", Description = "Elekto transport"},
                            new Category{CategoryName = "Classik cars", Description = "Avto s dvigatelem vnutrenego sgoraniya"}
                         };
                    category = new Dictionary<string, Category>();
                    foreach(Category el in list)
                       category.Add(el.CategoryName, el);
                    
                    }
                return category;
            } 
        }
    }
}
