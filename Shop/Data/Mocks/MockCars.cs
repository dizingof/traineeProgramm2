using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car>
                {
                    new Car {
                        Name = "Tesla Model S", 
                        ShortDescription="bistrii avtomobil", 
                        LongDescriprion="Tihii i bistrii avtomobil Tesla company", 
                        Img ="https://www.tesla.com/sites/tesla/files/curatedmedia/model-s-performance.jpg", 
                        Price = 45000, 
                        IsFavourite = true, 
                        Available = true, 
                        Category = categoryCars.AllCategories.First()
                    },
                    new Car {
                        Name = "Ford Fiesta",
                        ShortDescription="Tihii i spokoinii",
                        LongDescriprion="Udobnii avtomobil dlya goroda",
                        Img ="https://www.winnerauto.ua/uploads/gallery_photo/photo/0298/13.jpg?v2",
                        Price = 11000,
                        IsFavourite = true,
                        Available = true,
                        Category = categoryCars.AllCategories.Last()
                    },
                    new Car {
                        Name = "BMW M3",
                        ShortDescription="Race and style",
                        LongDescriprion="Udobnii avtomobil dlya goroda",
                        Img ="",
                        Price = 65000,
                        IsFavourite = true,
                        Available = true,
                        Category = categoryCars.AllCategories.Last()
                    },
                     new Car {
                        Name = "Mercedes C Class",
                        ShortDescription="Uiutniu i bolshoi",
                        LongDescriprion="Udobnii avtomobil dlya goroda",
                        Img ="http://www.mercedes-benz.in.ua/img/gallery/59/41/1761_wallpaper_1920_1200.jpg",
                        Price = 40000,
                        IsFavourite = true,
                        Available = true,
                        Category = categoryCars.AllCategories.Last()
                    },
                     new Car {
                        Name = "Nissan Leaf",
                        ShortDescription="besshumnii i ekonomichnii",
                        LongDescriprion="Udobnii avtomobil dlya goroda",
                        Img ="https://ecotechnica.com.ua/images/-foto3/210-nissan-leaf-2020-ecotechnicacomua-6.jpg",
                        Price = 14000,
                        IsFavourite = true,
                        Available = true,
                        Category = categoryCars.AllCategories.First()
                    },


                };
            }
        }
        public IEnumerable<Car> GetFavouriteCars { get; set; }

        public Car GetObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
