using System;
using System.Collections.Generic;
using System.Text;

namespace Vote.Model
{
    /// <summary>
    /// API接口返回参数
    /// </summary>
    public class Result<T>
    {
        /// <summary>
        /// 状态:0失败，1成功
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 提示
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 返回数据
        /// </summary>
        public T Data { get; set; }
    }
    /// <summary>
    /// API接口返回参数
    /// </summary>
    public class Result : Result<String>
    {
    }
}
