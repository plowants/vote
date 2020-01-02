using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vote.Model;
using Vote.Model.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vote.API.Member
{
    /// <summary>
    /// 用户登陆相关API接口
    /// </summary>
    [Route("[controller]")]
    public class LoginController : Controller
    {
        /// <summary>
        /// 用户登陆
        /// </summary>
        /// <param name="input">登陆参数</param>
        /// <returns></returns>
        [HttpPost("/login")]
        public Result Login([FromBody]LoginInput input)
        {
            return new Result();
        }

        // GET api/<controller>/5
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Id参数</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpGet("/")]
        [HttpPost("/")]
        public dynamic Post()
        {
            return new Result();
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
