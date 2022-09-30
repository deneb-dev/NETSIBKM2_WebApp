using Microsoft.EntityFrameworkCore;
using NETSIBKM2_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETSIBKM2_WebApp.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> dbContext) : base(dbContext)
        {

        }






        // Mengatur connection string (done)
        // menambahkan model untuk diolah dan / atau migrasi (done)

        /* 
         Code first
         */


        public DbSet<Province> Provinces { get; set; }
        public DbSet<Region> Regions { get; set; }
    }
}



//< select asp -for= "RegionId" class= "form-select" asp - items = "ViewBag.RegionId" >

                    //    < option ></ option >


                    //    < option value = "Waktu Indonesia Barat" > Waktu Indonesia Barat</option>
                    //         <option value = "Waktu Indonesia Tengah" > Waktu Indonesia Tengah</option>
                    //<option value = "Waktu Indonesia Timur" > Waktu Indonesia Timur</option>

//                </select>