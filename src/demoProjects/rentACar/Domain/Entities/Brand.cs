﻿using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Brand : Entity
    {
        public string Name { get; set; }


        public Brand()
        {

        }

        public Brand(int id, string name) : this() //this :> parametresiz constructorlarıda böyle çalıştır.
        {
            Id = id;
            Name = name;
        }
    }
}
