using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VRMS_3layers.BLL;
using VRMS_3layers.BLL.User;
using VRMS_3layers.Models.ResultObj;

namespace VRMS_MD.Controllers.User
{
    [Route("api/Department")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        [HttpGet]
        [Route("/GetAllDepartment")]
        public ResultObject getListDepartment()
        {
            return DepartmentBLL.getListDepartment();
        }
    }
}
