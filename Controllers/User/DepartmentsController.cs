using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using VRMS_3layers.BLL.User;
using VRMS_3layers.Models.ResultObj;
using VRMS_3Layers.Models.User;

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

        [HttpPost]
        [Route("AddNewDepartment")]
        public ResultObject addNewDepartment([FromBody] MdDepartment mdDepartment)
        {
            return DepartmentBLL.addNewDepartment(mdDepartment);
        }
    }
}
