using Microsoft.AspNetCore.Mvc;
using server.Data;
using server.Model;

namespace server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        public static List<TestDataDto> datas = new()
        {
            new TestDataDto { id = 1, name = "香蕉", category = "水果", price = 50 },
            new TestDataDto { id = 2, name = "蘋果", category = "水果", price = 35 },
            new TestDataDto { id = 3, name = "西瓜", category = "水果", price = 182 },
            new TestDataDto { id = 4, name = "牛奶", category = "飲料", price = 40 },
            new TestDataDto { id = 5, name = "咖啡", category = "飲料", price = 65 },
            new TestDataDto { id = 6, name = "可樂", category = "飲料", price = 29 },
        };

        [HttpGet]
        public IActionResult GetData()
        {
            return Ok(datas);
        }

        [HttpGet("{id}")]
        public IActionResult GetData(int id)
        {
            var data = datas.FirstOrDefault(x => x.id == id);
            return Ok(data);
        }

        [HttpPost]
        public IActionResult AddData(TestDataDto request)
        {
            int id = datas.Count > 0 ? datas.Max(x => x.id) + 1 : 1;
            var data = new TestDataDto { id = id, name = request.name, category = request.category };
            datas.Add(data);
            return Ok(data);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateData(int id, TestDataDto request)
        {
            var data = datas.FirstOrDefault(x => x.id == id);
            if (data == null)
            {
                return NotFound();
            }
            data.name = request.name;
            data.category = request.category;
            return Ok(data);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteData(int id)
        {
            var data = datas.FirstOrDefault(x => x.id == id);
            if (data == null)
            {
                return NotFound();
            }
            datas.Remove(data);
            return Ok(data);
        }

    }
}