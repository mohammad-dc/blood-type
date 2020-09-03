using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCURD.Models
{
    public class DonationDBContext:DbContext
    {//step 2
        public DonationDBContext(DbContextOptions<DonationDBContext> options):base(options)
        {

        }
        //step 3
        public DbSet<DCandidate> DCandidates { get; set; }
    }
}
