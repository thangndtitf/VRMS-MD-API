
using Microsoft.AspNetCore.Mvc;
using VRMS_3layers.Models.ResultObj;
using VRMS_3Layers.BLL.User;
using VRMS_3Layers.Models.User;

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

        [HttpPost]
        [Route("/insertNewPosition")]
        public ResultObject insertNewPosition([FromBody] MdPosition mdPosition)
        {
            return PositionBLL.insertNewPosition(mdPosition);
        }

        [HttpPost]
        [Route("/updatePosition")]
        public ResultObject updatePosition([FromBody] MdPosition mdPosition)
        {
            return PositionBLL.updatePosition(mdPosition);
        }


        [HttpPost]
        [Route("/deletePosition")]
        public ResultObject deletePosition([FromBody] decimal positionId)
        {
            return PositionBLL.deletePosition(positionId);
        }
    }
}

