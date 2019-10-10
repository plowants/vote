using Vote.Model;

namespace Vote.Model.DbEntity
{
    /// <summary>
    /// 活动奖品
    /// </summary>
    public class ActivityPrize : EntityExtend
    {
        /// <summary>
        /// 活动标识Id
        /// </summary>
        /// <value></value>
        public string ActivityId { get; set; }

        /// <summary>
        /// 奖品名称
        /// </summary>
        public string PrizeName { get; set; }

        /// <summary>
        /// 奖品级别
        /// </summary>
        public int PriceLevel { get; set; }
    }
}