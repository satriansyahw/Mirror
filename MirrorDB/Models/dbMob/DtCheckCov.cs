﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static MirrorDB.MirrorDBContext;

namespace MirrorDB.Models.dbMob
{
    [Table("DTCheckCov", Schema = "covid")]
    public class DtCheckCov : DefaultTableColumn
    {
        //[Column(Order = 0), Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [IndexAttribute(IsClustered = true, IsUnique = true)]

        [Column(Order = 1), Required ]
        public int EmpID { get; set; }
        //[IndexAttribute(IsClustered = true, IsUnique = true)] 

        [Column(Order = 2), Required]
        public DateTime TimeCheck { get; set; }
        [Column(Order = 3), Required, MaxLength(5)]
        public string Temperature { get; set; }
        [Column(Order = 4),  MaxLength(200)]
        public string Location { get; set; }
        [Column(Order = 5), MaxLength(300)]
        public string Note { get; set; }
         

    }

}
