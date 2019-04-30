using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Newinfosoft.Historytd.Entity
{
    /// <summary>
    /// 事件
    /// </summary>
    [Table("T_BASIC_EVENT")]
    public partial class EventBase
    {
        /// <summary>
        /// 事件开始日期
        /// </summary>
        [Required]
        public Date BeginDate { get; set; }

        /// <summary>
        /// 事件结束日期
        /// </summary>
        [Required]
        public Date EndDate { get; set; }

        /// <summary>
        /// 事件标题
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        /// <summary>
        /// 摘要
        /// </summary>
        [MaxLength(500)]
        public string Abstract { get; set; }


    }
}
