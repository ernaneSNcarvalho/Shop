using Microsoft.AspNetCore.Mvc;


namespace Shop.Controllers
{
    [Route("categories")]
    public class CategoryController : ControllerBase
    {
        [Route("")]
        public string MeuMetodo()
        {
            return "Ola mundo";
        }
    }
}