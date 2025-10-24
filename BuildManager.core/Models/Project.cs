using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildManager.core.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string RepositoryUrl { get; set; } = string.Empty;
        public string Branch {  get; set; } = "main";
        public string Environment { get; set; } = "dev"; //dev or prod
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
