using System;
using Vote.Model.Enums;

namespace Vote.Model.DbEntity
{
    public class EntityBase
    {
        /// <summary>
        /// 标识Id PimaryKey
        /// </summary>
        /// <value></value>
        public string Id { get; set; }
    }

    /// <summary>
    /// 实体扩展、包含时间状态
    /// </summary>
    public class EntityExtend : EntityBase
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        /// <value></value>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        /// <value></value>
        public DateTime ReviseTime { get; set; }

        /// <summary>
        /// 数据状态：0.删除，1.正常,2.禁用
        /// </summary>
        /// <value></value>
        public EStatus Status { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        /// <value></value>
        public string Remark { get; set; }
    }
}