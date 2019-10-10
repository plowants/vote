using System;
using Vote.Model.Enums;

namespace Vote.Model.DbEntity
{
    /// <summary>
    /// 支付记录
    /// </summary>
    public class Payment : EntityExtend
    {
        /// <summary>
        /// 支付单号
        /// </summary>
        public string No { get; set; }

        /// <summary>
        /// 第三方支付返回的支付单号
        /// </summary>
        public string PayNo { get; set; }

        /// <summary>
        /// 支付状态：0未支付，1.支付中，2支付成功，3支付失败
        /// </summary>
        public EPayStatus PayStatus {get;set;}

        /// <summary>
        /// 支付方式：1.微信，2支付宝
        /// </summary>
        public EPayWay PayWay { get; set; }

        /// <summary>
        /// 支付方式分支：1.微信H5，2微信小程序支付，3，微信原生支付，4，微信扫码支付，5.微信H5非微信浏览器支付，11支付宝原生支付
        /// </summary>
        public EChildPayWay ChildPayWay { get; set; }

        /// <summary>
        /// 请求参数；Json格式记录
        /// </summary>
        public String RequstData { get; set; }

        /// <summary>
        /// 相应结果数据
        /// </summary>
        public string ResponseData { get; set; }
    }
}