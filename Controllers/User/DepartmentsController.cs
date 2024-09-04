using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using VRMS_3layers.BLL.User;
using VRMS_3layers.Models.ResultObj;
using VRMS_3Layers.Models;

namespace VRMS_MD.Controllers.User
{
    [Route("api/Department")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        [HttpGet]
        [Route("getAllDepartment")]
        public ResultObject getListDepartment()
        {
            return DepartmentBLL.getListDepartment();
        }

        [HttpPost]
        [Route("addNewDepartment")]
        public ResultObject addNewDepartment([FromBody] MdDepartment mdDepartment)
        {
            return DepartmentBLL.addNewDepartment(mdDepartment);
        }

        [HttpPost]
        [Route("updateDepartment")]
        public ResultObject updateDepartment([FromBody] MdUpdateDepartment updateDepartment)
        {
            return DepartmentBLL.updateDepartment(updateDepartment);
        }

        [HttpPost]
        [Route("deleteDepartment")]
        public ResultObject deleteDepartment([FromBody] decimal deleteDepartmentId)
        {
            return DepartmentBLL.deleteDepartment(deleteDepartmentId);
        }

    }
}
