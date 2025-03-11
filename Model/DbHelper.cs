using SpaceWebApi.EfCore;

namespace SpaceWebApi.Model
{
    public class DbHelper
    {
        private EF_DataContext _context;
        public DbHelper(EF_DataContext context)
        {
            _context = context; 
        }

        //Get 
        public List<ClientesModel> GetClientes()
        {
            List<ClientesModel> response = new List<ClientesModel>();
            var dataList = _context.Clientes.ToList();
            dataList.ForEach(row => response.Add(new ClientesModel()
            {
                numero_id = row.numero_id,
                nombre = row.nombre
            }));

            return response;
        }
        ///< resumen>
        /// it serves the post / put / patch
        /// 
        /// </resumen>
        /// 

        public ClientesModel GetClientesById(int numero_id)
        {
            ClientesModel response = new ClientesModel();
            var row = _context.Clientes.Where(d =>d.numero_id.Equals(numero_id)).FirstOrDefault();
            return new ClientesModel()
            {
                numero_id = row.numero_id,
                nombre = row.nombre
            };
                          
        }
        public void SaveOrder(PedidosModel pedidosModel)
        {
            Pedidos dbTable = new Pedidos();
            if (pedidosModel.order_id > 0)
            {
                dbTable = _context.Pedidos.Where(d => d.customer_id.Equals(pedidosModel.customer_id)).FirstOrDefault();

                if (dbTable != null)
                {

                    dbTable.customer_id = pedidosModel.customer_id;
                    dbTable.producto = pedidosModel.producto;
                   }
                }
                else
                {
                    dbTable.customer_id = pedidosModel.customer_id;
                    dbTable.producto = pedidosModel.producto;
                    dbTable.order_id = pedidosModel.order_id;
                    _context.Pedidos.Add(dbTable);
                }
                _context.SaveChanges();
            }



        // Delete
        public void DeleteClient(int numero_id)
        {
            var client = _context.Clientes.FirstOrDefault(c => c.numero_id == numero_id);

            if (client != null)
            {
                Console.WriteLine($"Eliminando cliente con ID: {numero_id}");
                _context.Clientes.Remove(client);
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine($"No se encontró el cliente con ID: {numero_id}");
            }
        }

    }
}
