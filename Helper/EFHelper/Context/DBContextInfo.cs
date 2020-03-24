using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFHelper.Context
{
    public class DBContextInfo
    {
        public static DbContext MyDbContext { get; set; }
    }
}
