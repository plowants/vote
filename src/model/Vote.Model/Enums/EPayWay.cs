namespace Vote.Model.Enums
{
    /// <summary>
    /// 支付方式：1.微信，2支付宝
    /// </summary>
    public enum EPayWay
    {
        微信 = 1,
        支付宝 = 2
    }

    /// <summary>
    /// 支付方式分支：1.微信H5，2微信小程序支付，3，微信原生支付，4，微信扫码支付，5.微信H5非微信浏览器支付，11支付宝原生支付
    /// </summary>
    public enum EChildPayWay
    {
        微信原生支付 = 1,
        微信小程序支付 = 2,
        微信扫码支付 = 3,
        微信H5微信浏览器支付 = 4,
        微信H5非微信浏览器支付 = 5,
        支付宝原生支付 = 11,
    }
}