using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Newinfosoft.Historytd.Entity
{
    /// <summary>
    /// 所有对象的父类
    /// </summary>
    public class ObjectBase
    {
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

        /// <summary>
        /// 用作Concurrency token
        /// </summary>
        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
