namespace Vote.Model.Enums
{
    /// <summary>
    /// 审核状态：0待提审，1.审核中，2审核通过，3.审核不通过
    /// </summary>
    public enum EVerifyStatus
    {
        待提审 = 0,
        审核中 = 1,
        审核通过 = 2,
        审核不通过 = 3
    }
}