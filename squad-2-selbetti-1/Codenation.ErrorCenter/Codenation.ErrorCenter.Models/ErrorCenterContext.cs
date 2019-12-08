using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codenation.ErrorCenter.Models
{
    public class ErrorCenterContext : DbContext
    {
        // this constructor is for enable testing with in-memory data
        public ErrorCenterContext(DbContextOptions<ErrorCenterContext> options)
            : base(options)
        {
        }
    }
}
