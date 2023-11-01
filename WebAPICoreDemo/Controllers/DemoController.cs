using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPICoreDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpPost("Report")]
        public async Task<List<Demo>> Report()
        {
            var list = new List<Demo>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(new Demo { Id = i, qrBuyer = "qrBuyer " + i, qrColor = "qrColor " + i, qrPO = "qrPO " + i, qrSizeName = "qrSizeName " + i, qrStyle_No = "qrStyle_No " + i });
            }

            return list;
        }

        [HttpPost("Demo_Detail")]
        public async Task<Demo> Demo_Detail(Demo_DetailRequestData requestData)
        {
            var list = new List<Demo>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(new Demo { Id = i, qrBuyer = "qrBuyer " + i, qrColor = "qrColor " + i, qrPO = "qrPO " + i, qrSizeName = "qrSizeName " + i, qrStyle_No = "qrStyle_No " + i });
            }

            return list.FindAll(s => s.Id == requestData.Id).FirstOrDefault();
        }
    }

    public class Demo
    {
        public int Id { get; set; }
        public string qrStyle_No { get; set; }
        public string qrBuyer { get; set; }
        public string qrSizeName { get; set; }
        public string qrColor { get; set; }
        public string qrPO { get; set; }
    }
}
