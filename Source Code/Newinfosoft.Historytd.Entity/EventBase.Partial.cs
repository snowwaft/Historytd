﻿using System;
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
    }
}
