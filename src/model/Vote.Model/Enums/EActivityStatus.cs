namespace Vote.Model.Enums
{
    /// <summary>
    /// 活动状态：0.未启用，1.启用，2.暂停
    /// </summary>
    public enum EActivityStatus
    {
        未启用=0,
        启用=1,
        暂停=2
    }

    /// <summary>
    /// 活动类型：1.投票活动，2.答题活动
    /// </summary>
    public enum EActivityType{
        投票活动=1,
        答题活动=2
    }
}