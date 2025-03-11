using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SpaceWebApi.EfCore
{
    [Table("clientes")]
    public class Clientes
    {
        [Key, Required]

        public int numero_id { get; set; }

        public string nombre { get; set; } = String.Empty;

    }
}
