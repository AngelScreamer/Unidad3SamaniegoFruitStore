using Unidad3SamaniegoFruitStore.Models;
using Unidad3SamaniegoFruitStore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unidad3SamaniegoFruitStore.Services
{
    public class CategoriasService
    {
        public List<Categorias> Categorias { get; set; }

        public CategoriasService()
        {
            using (fruteriashopContext context = new fruteriashopContext())
            {
                Repository<Categorias> repos = new Repository<Categorias>(context);
                Categorias = repos.GetAll().Where(x=>x.Eliminado==0).OrderBy(x=>x.Nombre).ToList();
            }
        }
    }
}
