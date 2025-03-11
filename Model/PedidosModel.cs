using System.ComponentModel.DataAnnotations;


namespace SpaceWebApi.Model
{
    public class PedidosModel
    {
       
        public int order_id { get; set; }
    
        public int customer_id { get; set; }
        
       
        public string producto { get; set; } = String.Empty;

    }
}
