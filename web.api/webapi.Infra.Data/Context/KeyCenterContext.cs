using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using webapi.Domain.Models;

namespace webapi.Infra.Data.Context
{
    public class KeyCenterContext : DbContext
    {
        public KeyCenterContext(DbContextOptions<KeyCenterContext> options) : base(options)
        {
        }

        public DbSet<KeyObject> RegisteredKeys { get; set; }
    }
}
