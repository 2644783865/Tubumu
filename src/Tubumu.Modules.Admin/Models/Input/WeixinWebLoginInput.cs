﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Tubumu.Modules.Framework.ModelValidation.Attributes;


namespace Tubumu.Modules.Admin.Models.Input
{
    /// <summary>
    /// 网页回调
    /// </summary>
    public class WeixinWebLoginInput
    {
        /// <summary>
        /// 微信登录 Code
        /// </summary>
        [Required(ErrorMessage = "微信登录 Code")]
        public string Code { get; set; }

        /// <summary>
        /// 回传数据
        /// 第三方程序发送时用来标识其请求的唯一性的标志，由第三方程序调用sendReq时传入，由微信终端回传，state字符串长度不能超过1K
        /// </summary>
        public string State {get;set;}

    }
}
