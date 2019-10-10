namespace Vote.Model.DbEntity
{
    public class WxAuthorization : EntityExtend
    {
        /// <summary>
        /// 微信OpenId
        /// </summary>
        public string ExOpenId { get; set; }

        /// <summary>
        /// 用户Id  可空
        /// </summary>
        public string MemberId { get; set; }

        /// <summary>
        /// 平台Id
        /// </summary>
        public string PlatformId { get; set; }
    }
}