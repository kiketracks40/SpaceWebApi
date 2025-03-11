using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SpaceWebApi.EfCore
{
    [Table("pedidos")]
    public class Pedidos
    {
        [Key, Required]

        public int order_id { get; set; }

        public int customer_id { get; set; }

        public string producto { get; set; } = String.Empty;

    }
}