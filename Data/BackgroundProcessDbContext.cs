using Microsoft.EntityFrameworkCore;
using POC_BackgroungProcessUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_BackgroungProcessUI.Data
{
    public class BackgroundProcessDbContext : DbContext
    {
        #region properties
        public DbSet<BrowserInfo> BrowserInfos { get; set; }
        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=BrowserInfo.db");
    }
}
