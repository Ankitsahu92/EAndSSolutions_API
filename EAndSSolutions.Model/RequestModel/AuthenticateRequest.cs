﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAndSSolutions.Model.RequestModel
{
    public class AuthenticateRequest
    {
        [Required]
        [DefaultValue("System@gmail.com")]
        public string? Username { get; set; }

        [Required]
        [DefaultValue("System@1234")]
        public string? Password { get; set; }
    }
}
