using System;
using Vote.Model.Enums;

namespace Vote.Model.DbEntity
{
    /// <summary>
    /// 推广活动信息
    /// </summary>
    public class Activity:EntityExtend
    {
        /// <summary>
        /// 活动名称
        /// </summary>
        /// <value></value>
        public string ActivityName{get;set;}

        /// <summary>
        /// 活动开始时间
        /// </summary>
        /// <value></value>
        public DateTime StartTime{get;set;}

        /// <summary>
        /// 活动结束时间
        /// </summary>
        /// <value></value>
        public DateTime EndTime{get;set;}

        /// <summary>
        /// 活动类型：1.投票活动，2.答题活动
        /// </summary>
        /// <value></value>
        public EActivityType ActivityType{get;set;}

        /// <summary>
        /// 活动状态：0.未启用，1.启用，2.暂停
        /// </summary>
        /// <value></value>
        public EActivityStatus ActivityStatus{get;set;}
    }
}