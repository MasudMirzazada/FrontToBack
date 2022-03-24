using FTPMentor.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FTPMentor.DAL
{
    public class MentorDB:DbContext
    {
        public MentorDB(DbContextOptions<MentorDB>options ):base(options)
        {

        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutImages> AboutImages { get; set; }
    }
}
