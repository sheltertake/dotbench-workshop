using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace MemoryUsageApi.Controllers
{
    [Route("memory")]
    [ApiController]
    public class MemoryController : ControllerBase
    {
        private const int MEGA = 1024 * 1024;
        public static byte[] MyByteArray = new byte[0];
        public static Dictionary<int, byte[]> MyDictionary = new Dictionary<int, byte[]>();

        [HttpGet]
        [Route("short/{mb}")]
        public ActionResult<object> Short(int mb)
        {
            var data = new byte[mb * MEGA];
            return new
            {
                MyDictionary = MyDictionary.Sum(x => x.Value.Length / MEGA),
                MyByteArray = (MyByteArray.Length / MEGA),
                Short = data.Length / MEGA
            };

        }

        [HttpGet]
        [Route("static/{mb}")]
        public ActionResult<object> S(int mb)
        {
            MyByteArray = new byte[mb * MEGA];
            return new
            {
                MyDictionary = MyDictionary.Sum(x => x.Value.Length / MEGA),
                MyByteArray = (MyByteArray.Length / MEGA)
            };
        }

        [HttpGet]
        [Route("dictionary/{key}/{mb}")]
        public ActionResult<object> D(int key, int mb)
        {
            MyDictionary[key] = new byte[mb * MEGA];
            return new
            {
                MyDictionary = MyDictionary.Sum(x => x.Value.Length / MEGA),
                MyByteArray = (MyByteArray.Length / MEGA)
            };
        }
    }
}