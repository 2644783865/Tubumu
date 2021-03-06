﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubumu.Modules.Admin.Models.Input
{
    /// <summary>
    /// 父 Id Input
    /// </summary>
    public class ParentIdInput
    {
        /// <summary>
        /// 父 Id
        /// </summary>
        [Range(1, Int32.MaxValue, ErrorMessage = "请输入 ParentId")]
        public int ParentId { get; set; }
    }

    /// <summary>
    /// 父 Id Input
    /// </summary>
    public class ParentIdNullableInput
    {
        /// <summary>
        /// 父 Id
        /// </summary>
        [Range(1, Int32.MaxValue, ErrorMessage = "请输入 ParentId")]
        public int? ParentId { get; set; }
    }

    /// <summary>
    /// 父 Id 路径
    /// </summary>
    public class ParentIdPathInput
    {
        /// <summary>
        /// 父 Id
        /// </summary>
        public int[] ParentIdPath { get; set; }
    }
}
