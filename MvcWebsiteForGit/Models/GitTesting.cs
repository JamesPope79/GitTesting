using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcWebsiteForGit.Models
{
    public class GitTesting
    {
        [Key]
        public int ID { get; set; }
        public string GitName { get; set; }
        public int GitAge { get; set; }
    }
}