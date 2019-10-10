namespace Vote.Model.Enums
{
    /// <summary>
    ///  缴费状态：0未缴费，1已缴费  （免费的平台无需缴费，需缴费的平台，需缴费后才能使用）
    /// </summary>
    public enum EPayCostStatus
    {
        未缴费 = 0,
        已缴费 = 1
    }

    /// <summary>
    /// 收费类型：0免费，1收费，2试用
    /// </summary>
    public enum EChargetype
    {
        免费 = 0,
        收费 = 1,
        试用 = 2
    }
}