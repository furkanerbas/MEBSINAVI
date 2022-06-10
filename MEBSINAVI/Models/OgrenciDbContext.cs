using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MEBSINAVI.Models
{
    public class OgrenciDbContext : DbContext
    {
        public OgrenciDbContext() : base("name=myCon")
        {
            
        }
        public virtual DbSet<Ogrenci> Ogrenciler { get; set; }

    }
}