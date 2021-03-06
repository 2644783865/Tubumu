﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubumu.Modules.Admin.Models.Input
{
    /// <summary>
    /// 区域 Id Input
    /// </summary>
    public class RegionIdInput
    {
        /// <summary>
        /// 区域 Id
        /// </summary>
        [Range(1, Int32.MaxValue, ErrorMessage = "请输入 RegionId")]
        public int RegionId { get; set; }
    }
}
