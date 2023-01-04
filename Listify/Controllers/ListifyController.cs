using Microsoft.AspNetCore.Mvc;

namespace Listify.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListifyController : ControllerBase
    {
        [Microsoft.AspNetCore.Mvc.HttpGet]
        [Route("api/listify/{begin}/{end}/{index}")]
        public int Get(int begin, int end, int index)
        {
            List<int> list = new List<int>();

            IEnumerable<int> enumerable = Enumerable.Range(begin, end);

            foreach (var item in enumerable)
            {
                list.Add(item);
            }

            return list[index];
        }
    }
}