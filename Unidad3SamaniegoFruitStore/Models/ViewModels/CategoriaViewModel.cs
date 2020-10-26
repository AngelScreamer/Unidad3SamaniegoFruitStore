using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unidad3SamaniegoFruitStore.Models.ViewModels
{
    public class CategoriaViewModel
    {
        public string Nombre { get; set; }
        public IEnumerable<Productos> Productos { get; set; }
    }
}
