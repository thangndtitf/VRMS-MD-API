using Microsoft.AspNetCore.Mvc;
using VRMS_3layers.Models.ResultObj;
using VRMS_3Layers.BLL.User;
using VRMS_3Layers.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VRMS_MD.Controllers.User
{
    [Route("api/Users")]
    public class UsersController : Controller
    {
        [HttpGet]
        [Route("/getAllUser")]
        public ResultObject getListUser()
        {
            return UserBLL.GetListUser();
        }

        [HttpPost]
        [Route("/AddNewUser")]
        public ResultObject addNewUser([FromBody]MdUser newUser)
        {
            return UserBLL.InsertNewUser(newUser);
        }

        [HttpPost]
        [Route("/UpdateUser")]
        public ResultObject updateUser([FromBody]MdUpdateUser updateUser)
        {
            return UserBLL.UpdateUser(updateUser);
        }

        [HttpPost]
        [Route("DeleteUser")]
        public ResultObject deleteUser([FromBody]decimal userName)
        {
            return UserBLL.DeleteUser(userName);
        }
    }
}

