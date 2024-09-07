using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoCategorias.Models
{
    public class Item
    {
        public long Id { get; set; }

        public string? Name { get; set; }
        
        public long ItemId { get; set; }
        [ForeignKey("ItemId")]
        public Categoria? Categoria { get; set; }
    }
}
