using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace WebApplication1.Models
{
    public class UserModel
    {
        /// <summary>
        /// 名前
        /// </summary>
        [DisplayName("お名前")]
        public string Name { get; set; }
    }
}