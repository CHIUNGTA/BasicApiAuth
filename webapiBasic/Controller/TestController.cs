using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using webapiBasic.Basic;
using webapiBasic.Model;
using System.Web.Http.Description;
using System;
using System.Threading;
using webapiBasic.Utility;
using System.Collections.Generic;

namespace webapiBasic.Controller
{
    public class TestController : ApiController
    {
        /// <summary>
        /// Get測試
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [SwaggerOperation("GetAll")]
        [ApiBasicAuthenticationFilter]
        public string Get()
        {
            return "Ho~ Yes!";
        }

        /// <summary>
        /// Get測試2
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [SwaggerOperation("GetAll2")]
        [ApiBasicAuthenticationFilter]
        public string Get2()
        {
            return "Ho~ No!";
        }

        /// <summary>
        /// 自我介紹
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        [HttpPost]
        [SwaggerOperation("PostList")]
        [ApiBasicAuthenticationFilter]
        public string Come(PostInfo i)
        {
            string date = DateTime.Now.ToString("yyyyMMddHHmmss");
            return string.Format("測試人:{0}   年齡:{1}   你的學校:{2}   回應時間:{3}" , i.Name , i.Age ,i.School ,date);
        }

        /// <summary>
        /// 取得兩日期區間內所有的日期
        /// </summary>
        /// <param name="date"></param>
        /// <returns>取得日期區間</returns>
        [HttpPost]
        [SwaggerOperation("Timer")]
        [ApiBasicAuthenticationFilter]
        //[ResponseType(typeof(IEnumerable<ProductViewModel>))]
        public IEnumerable<DateTime> GetTimeGap([FromBody]GetTimeGapInfo date)
        {
            return MyTime.EachDay(date.Start, date.End);
        }


    }

  
}
