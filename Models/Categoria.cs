using ProjetoCategorias.Migrations;
using ProjetoCategorias.Models;

namespace ProjetoCategorias.Models
{
    public class Categoria
    {        
        public long Id { get; set; }

        public string? Name { get; set; }

        public List<Item>? Items { get; set; }
    }
}