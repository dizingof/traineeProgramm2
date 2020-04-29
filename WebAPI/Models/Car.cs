using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Car
    {
        public string Name { get; set; }
        public Car(string imya)
        {
            Name = imya;
        }
    }
}