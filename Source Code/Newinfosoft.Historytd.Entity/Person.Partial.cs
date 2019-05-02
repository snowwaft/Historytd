using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Newinfosoft.Historytd.Entity
{
    partial class Person
    {
        /// <summary>
        /// 人物Id
        /// </summary>
        [Key]
        public Guid Id { get; set; }
    }
}
