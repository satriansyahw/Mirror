using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFHelper.Context
{
    public interface InterfaceDBContext
    {
        DbContext CreateConnectionContext();
        void SetConnectionContext(DbContext dbContext);
    }
}
