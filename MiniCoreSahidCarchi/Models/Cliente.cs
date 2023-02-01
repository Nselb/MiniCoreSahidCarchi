using System.ComponentModel.DataAnnotations;

namespace MiniCoreSahidCarchi.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
