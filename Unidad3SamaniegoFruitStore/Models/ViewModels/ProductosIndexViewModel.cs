﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unidad3SamaniegoFruitStore.Models.ViewModels
{
    public class ProductosIndexViewModel
    {
        public IEnumerable<Productos> Productos { get; set; }
        public IEnumerable<Categorias> Categorias { get; set; }
        public int IdCategoria { get; set; }
    }
}
