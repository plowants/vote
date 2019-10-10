using Vote.Model.Enums;

namespace Vote.Model.DbEntity
{
    public class Platform : EntityExtend
    {
        /// <summary>
        /// 平台名称
        /// </summary>
        public string PlatformName { get; set; }
        
        /// <summary>
        /// 审核状态：0待提审，1.审核中，2审核通过，3.审核不通过
        /// </summary>
        public EVerifyStatus VerifyStatus { get; set; }

        /// <summary>
        /// 收费类型：0免费，1收费，2试用
        /// </summary>
        public EChargetype Chargetype { get; set; }

        /// <summary>
        /// 缴费状态：0未缴费，1已缴费  （免费的平台无需缴费，需缴费的平台，需缴费后才能使用）
        /// </summary>
        public EPayCostStatus PayCostStatus { get; set; }
    }
}