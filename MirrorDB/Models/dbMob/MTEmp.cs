using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static MirrorDB.MirrorDBContext;

namespace MirrorDB.Models.dbo
{
    [Table("MTEmp", Schema = "covid")]
    public class MTEmp:DefaultTableColumn
    {
        //[Column(Order = 0), Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [IndexAttribute(IsClustered = true, IsUnique = true)]
        [Column(Order = 1), Required, MaxLength(100)]
        public string EmpNo { get; set; }
        [IndexAttribute(IsClustered = true, IsUnique = true)]
        [Column(Order = 2), Required, MaxLength(200)]
        public string EmpName { get; set; }
        [Column(Order = 3), Required, MaxLength(100)]
        public string EmpPhone { get; set; }

    }
}
