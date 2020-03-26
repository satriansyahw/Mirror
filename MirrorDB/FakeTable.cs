using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static MirrorDB.MirrorDBContext;

namespace MirrorDB
{
    [Table("FakeTable", Schema = "fake")]
    public class FakeTable
    {
        [Column(Order = 0), Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //[Column(Order = 1), Required, MaxLength(20)]
        public string UserName { get; set; }

        //[IndexAttribute(IsClustered = true, IsUnique = true)]
        public string UserName2 { get; set; }

        //[MultiplePK(IsMultiplePK = true)]
        public string UserName3 { get; set; }
       // [Column(Order = 0), Key, Required]
        public bool active_bool { get; set; }

        public string insert_by { get; set; }
        public System.DateTime insert_date { get; set; }
        public string update_by { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
    }
}
