using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ST10198206_CLDV6211_POEPartTwo.Models;

namespace ST10198206_CLDV6211_POEPartTwo.Data
{
    public class ST10198206_CLDV6211_POEPartTwoContext : DbContext
    {
        public ST10198206_CLDV6211_POEPartTwoContext (DbContextOptions<ST10198206_CLDV6211_POEPartTwoContext> options)
            : base(options)
        {
        }

        public DbSet<ST10198206_CLDV6211_POEPartTwo.Models.Item> Item { get; set; } 
    }
}
