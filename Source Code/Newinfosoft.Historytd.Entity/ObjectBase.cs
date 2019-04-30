using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Newinfosoft.Historytd.Entity
{
    /// <summary>
    /// 所有对象的父类
    /// </summary>
    public class ObjectBase
    {
        /// <summary>
        /// 用作Concurrency token
        /// </summary>
        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
