using Api_Karate_Pro.model.proc;
using Api_Karate_Pro.model.Request;
using Api_Karate_Pro.model.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Karate_Pro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeleaController : ControllerBase
    {
        [HttpGet]

        [Route("consultaTodo")]
        public Respuesta m_1_1()
        {
            Respuesta res = p_Pelea.consultaTodoPelea();
            return res;
        }


        [HttpPut]
        [Route("actualizar")]
        public Respuesta ro_1_2([FromBody] pelea_A_pelea pelea)
        {

            Respuesta res = p_Pelea.actualizaPelea(pelea);
            return res;
        }
        [HttpPost]

        [Route("grabar")]
        public Respuesta ro_1_3([FromBody] pelea_A_pelea pelea)
        {

            Respuesta res = p_Pelea.grabaPelea(pelea);
            return res;
        }


        [HttpDelete]
        [Route("eliminar/{pel_id}")]
        public Respuesta ro_1_4(int pel_id)
        {
            Respuesta res = p_Pelea.eliminaPelea(pel_id);
            return res;
        }
    }
}
