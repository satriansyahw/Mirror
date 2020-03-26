using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MirrorDB.Models
{
    public class DefaultTableColumn
    {
        [Key, Required]
        public bool activebool { get; set; }
        public string insertby { get; set; }
        public System.DateTime insertdate { get; set; }
        public string updateby { get; set; }
        public Nullable<System.DateTime> updatedate { get; set; }
    }
}
