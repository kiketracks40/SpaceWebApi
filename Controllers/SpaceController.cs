using Microsoft.AspNetCore.Mvc;
using SpaceWebApi.EfCore;
using SpaceWebApi.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaceWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpaceController : ControllerBase
    {
        private readonly DbHelper _db;

        public SpaceController(EF_DataContext eF_DataContext)
        {
            _db = new DbHelper(eF_DataContext);

        }

        // GET: api/<SpaceController>
        [HttpGet("GetClientes")]
        [Route("api/[controller]/GetClientes")]
        public IActionResult Get()
        {

            ResponseType type = ResponseType.Success;
            try
            {

                IEnumerable<ClientesModel> data = _db.GetClientes();

                
                if (!data.Any())
                {
                    type = ResponseType.NotFound;

                }
                return Ok(ResponseHandler.GetAppResponse(type, data));
            }

            catch (Exception ex)
            
            {
                
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));

            }
        }

        // GET api/<SpaceController>/5
        [HttpGet("GetClientesById/{numero_id}")]
        [Route("api/[controller]/GetClientesById/{numero_id}")]
        public IActionResult Get(int numero_id)
        {
            ResponseType type = ResponseType.Success;
            try
            {

                ClientesModel data = _db.GetClientesById(numero_id);


                if (data==null)
                {
                    type = ResponseType.NotFound;

                }
                return Ok(ResponseHandler.GetAppResponse(type, data));
            }

            catch (Exception ex)

            {
                
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));

            }
        }


        // POST api/<SpaceController>
        [HttpPost("SaveOrder")]
        [Route("api/[controller]/SaveOrder")]
        public IActionResult Post([FromBody] PedidosModel model)
        {
            try
            {
                ResponseType type = ResponseType.Success;
                _db.SaveOrder(model);
                return Ok(ResponseHandler.GetAppResponse(type, model));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }


        // PUT api/<SpaceController>/5
        [HttpPut("UpdateOrder")]
        [Route("api/[controller]/UpdateOrder")]
        public IActionResult Put( [FromBody] PedidosModel model)
        {
            try
            {
                ResponseType type = ResponseType.Success;
                _db.SaveOrder(model);
                return Ok(ResponseHandler.GetAppResponse(type, model));
            }

            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }



        // DELETE api/<SpaceController>/5
         [HttpDelete("DeleteOrder/{numero_id}")]
        //[Route("api/[controller]/DeleteOrder/{numero_id}")]
        public IActionResult Delete(int numero_id)
        {
            try
            {
                ResponseType type = ResponseType.Success;
                _db.DeleteClient(numero_id);
                return Ok(ResponseHandler.GetAppResponse(type, "Delete Successfully"));
            }

            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }

        }
    }
}
