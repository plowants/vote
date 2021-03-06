﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Vote.Model.DTO
{
    /// <summary>
    /// 用户登陆请求参数
    /// </summary>
    public class LoginInput
    {
        /// <summary>
        /// 登陆账号
        /// </summary>
        [Required]
        [Description("登陆账号")]
        public string LoginAccount { get; set; }

        /// <summary>
        /// 登陆密码
        /// </summary>
        [Required]
        public string LoginPwd { get; set; }

        /// <summary>
        /// 验证码
        /// </summary>
        [DefaultValue("123456")]
        public string Code { get; set; }
    }
}
