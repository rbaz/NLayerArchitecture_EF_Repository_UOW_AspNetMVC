using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace manageProjects.UI.Web.Models
{
    public class MyViewModel
    {
        public Model.Models.Project Project { get; set; }
        public static DateTime XDateTime { get; set; }
    }
}