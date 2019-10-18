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
        private const int KILO = 1024;
        public static byte[] MyByteArray = new byte[0];
        public static Dictionary<int, byte[]> MyDictionary = new Dictionary<int, byte[]>();

        [HttpGet]
        [Route("gen0/{NKB}")]
        public ActionResult<object> Gen0(int NKB)
        {
            var data = new byte[NKB * KILO];
            return new
            {
                MyDictionary = MyDictionary.Sum(x => x.Value.Length / MEGA)+ "Mb",
                MyByteArray = (MyByteArray.Length / MEGA) + "Mb",
                Volatile = data.Length / KILO + "Kb"
            };

        }

        [HttpGet]
        [Route("loh/{NMB}")]
        public ActionResult<object> Loh(int NMB)
        {
            var data = new byte[NMB * MEGA];
            return new
            {
                MyDictionary = MyDictionary.Sum(x => x.Value.Length / MEGA) + "Mb",
                MyByteArray = (MyByteArray.Length / MEGA) + "Mb",
                Volatile = data.Length / MEGA + "Mb",
            };

        }

        [HttpGet]
        [Route("loh/s/{NMB}")]
        public ActionResult<object> LohStatic(int NMB)
        {
            MyByteArray = new byte[NMB * MEGA];
            return new
            {
                MyDictionary = MyDictionary.Sum(x => x.Value.Length / MEGA) + "Mb",
                MyByteArray = (MyByteArray.Length / MEGA) + "Mb",
            };
        }

        [HttpGet]
        [Route("loh/d/{key}/{NMB}")]
        public ActionResult<object> D(int key, int NMB)
        {
            MyDictionary[key] = new byte[NMB * MEGA];
            return new
            {
                MyDictionary = MyDictionary.Sum(x => x.Value.Length / MEGA) + "Mb",
                MyByteArray = (MyByteArray.Length / MEGA) + "Mb",
            };
        }
    }
}