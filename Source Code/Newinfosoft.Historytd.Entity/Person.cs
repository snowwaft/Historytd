using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Newinfosoft.Historytd.Entity
{
    [Table("T_BASIC_PERSON")]
    public partial class Person : ObjectBase
    {
        /// <summary>
        /// 姓
        /// </summary>
        [Required]
        [MaxLength(16)]
        public string FamilyName { get; set; }

        /// <summary>
        /// 名
        /// </summary>
        [Required]
        [MaxLength(16)]
        public string FirstName { get; set; }

        /// <summary>
        /// 字
        /// </summary>
        [Required]
        [MaxLength(16)]
        public string MiddleName { get; set; }

        /// <summary>
        /// 生于
        /// </summary>
        public Date Birthday { get; set; }

        /// <summary>
        /// 忌日
        /// </summary>
        public Date Deathday { get; set; }

        /// <summary>
        /// 人物头像URL
        /// </summary>
        [MaxLength(200)]
        public string HeadImage { get; set; }

        /// <summary>
        /// 摘要，简单介绍
        /// </summary>
        [MaxLength(500)]
        public string Abstract { get; set; }

        #region Override Methods
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(FamilyName);
            sb.Append(FirstName);
            if (!string.IsNullOrEmpty(MiddleName))
            {
                sb.Append(ConstString.左括号);
                sb.Append(MiddleName);
                sb.Append(ConstString.右括号);
            }
            return sb.ToString();
        }
        #endregion
    }
}
