using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Newinfosoft.Historytd.Entity
{
    partial class EventBase : ObjectBase
    {
        /// <summary>
        /// 事件的Id，主键
        /// </summary>
        [Key]
        public Guid EventId { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreateTime { get; set; } = DateTime.Now;

        /// <summary>
        /// 上次更新日期
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime LastUpdateTime { get; set; } = DateTime.Now;
    }
}
