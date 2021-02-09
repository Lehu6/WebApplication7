using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApplication7.Models
{
    public class GlobalizationModel
    {
        [DisplayName("Angielski")]
        public bool English { get; set; }
    }
}