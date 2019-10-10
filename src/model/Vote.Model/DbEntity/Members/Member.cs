using System;
using Vote.Model.Enums;

namespace Vote.Model.DbEntity
{
    /// <summary>
    /// 会员/用户信息
    /// </summary>
    public class Member:EntityExtend
    {
        /// <summary>
        /// 用户名(昵称)
        /// </summary>
        /// <value></value>
        public string NickName{get;set;}

        /// <summary>
        /// 登陆账号
        /// </summary>
        /// <value></value>
        public string UserName{get;set;}

        /// <summary>
        /// 用户密码
        /// </summary>
        /// <value></value>
        public string Pwd{get;set;}

        /// <summary>
        /// 手机号
        /// </summary>
        /// <value></value>
        public string Phone{get;set;}

        /// <summary>
        /// 邮箱
        /// </summary>
        /// <value></value>
        public string Email{get;set;}

        /// <summary>
        /// 用户类型:1.系统管理员，2.平台管理员，3.用户
        /// </summary>
        public EUserType UserType { get; set; }
    }
}