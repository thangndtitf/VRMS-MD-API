
using Microsoft.AspNetCore.Mvc;
using VRMS_3layers.Models.ResultObj;
using VRMS_3Layers.BLL.User;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VRMS_MD.Controllers.User
{
    [Route("api/Position")]
    public class PositionController : Controller
    {
        [HttpGet]
        [Route("/getListPosition")]
        public ResultObject getListPosition()
        {
            return PositionBLL.getListPosition();
        }
    }
}

