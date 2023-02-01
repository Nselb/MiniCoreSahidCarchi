using System.ComponentModel.DataAnnotations;

namespace MiniCoreSahidCarchi.Models
{
    public class Contrato
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int ClientId { get; set; }
        public DateTime Fecha { get; set; }
        public int Montos { get; set; }

    }
}
