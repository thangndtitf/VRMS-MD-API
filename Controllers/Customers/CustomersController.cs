

using Microsoft.AspNetCore.Mvc;
using VRMS_3layers.BLL.Customer;
using VRMS_3layers.Models.ResultObj;
using VRMS_3Layers.Models;

namespace VRMS_MD.Controllers.Customers
{
    [Route("api/Customer")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private CustomerBLL customerBll = new CustomerBLL();

        [HttpGet]
        [Route("/GetListCustomers")]
        public ResultObject GetListCustomers()
        {
            return customerBll.GetListCustomer();
        }

        [HttpPost]
        [Route("InsertNewCus")]
        public ResultObject InsertNewCustomer([FromBody] MdCustomer customer)
        {
            return customerBll.AddNewCustomer(customer);
        }


        [HttpPost]
        [Route("UpdateCustomer")]
        public ResultObject UpdateCustomer([FromBody] MdCustomer customer)
        {
            return customerBll.UpdateCustomer(customer);
        }

        [HttpPost]
        [Route("DeleteCustomer")]
        public ResultObject DeleteCustomer([FromBody] decimal customerId)
        {
            return customerBll.DeleteCustomer(customerId);
        }

    }
}
