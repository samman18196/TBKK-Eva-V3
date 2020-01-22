using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace tbkkData.Models
{
    public class tbkkDataContext : DbContext
    {
        public tbkkDataContext (DbContextOptions<tbkkDataContext> options)
            : base(options)
        {
        }
        //public DbSet<tbkkData.Models.Asset> Asset { get; set; }
        //public DbSet<tbkkData.Models.AssetJoinNetwork> AssetJoinNetworks { get; set; }
        //public DbSet<tbkkData.Models.Brand> Brand { get; set; }
        //public DbSet<tbkkData.Models.Canteen> Canteen { get; set; }
        //public DbSet<tbkkData.Models.CarType> CarType { get; set; }
        //public DbSet<tbkkData.Models.Category> Category { get; set; }
        public DbSet<tbkkData.Models.Company> Company { get; set; }
        //public DbSet<tbkkData.Models.CompanyCar> CompanyCar { get; set; }
        //public DbSet<tbkkData.Models.Competency> Competency { get; set; }
        public DbSet<tbkkData.Models.Department> Department { get; set; }
        //public DbSet<tbkkData.Models.DetailOT> DetailOT { get; set; }
        public DbSet<tbkkData.Models.Employee> Employee { get; set; }
        public DbSet<tbkkData.Models.EmployeeType> EmployeeType { get; set; }

        //public DbSet<tbkkData.Models.FoodSet> FoodSet { get; set; }
        public DbSet<tbkkData.Models.GradeHistory> GradeHistory { get; set; }
       // public DbSet<tbkkData.Models.JoinAssetEmp> JoinAssetEmp { get; set; }
       // public DbSet<tbkkData.Models.JoinLicenseAsset> JoinLicenseAsset { get; set; }
       //// public DbSet<tbkkData.Models.KPI> KPI { get; set; }
       // public DbSet<tbkkData.Models.License> License { get; set; }
       // public DbSet<tbkkData.Models.Location> Location { get; set; }
        public DbSet<tbkkData.Models.Login> Login { get; set; }
        //public DbSet<tbkkData.Models.Model> Model { get; set; }
        //public DbSet<tbkkData.Models.Network> Network { get; set; }
        //public DbSet<tbkkData.Models.OT> OT { get; set; }
        //public DbSet<tbkkData.Models.Part> Part { get; set; }
        //public DbSet<tbkkData.Models.Point> Point { get; set; }
        public DbSet<tbkkData.Models.Position> Position { get; set; }
        ////public DbSet<tbkkData.Models.Relationship> Relationship { get; set; }
        ////public DbSet<tbkkData.Models.Repair> Repair { get; set; }
        ////public DbSet<tbkkData.Models.Report> Report { get; set; }
       // public DbSet<tbkkData.Models.Suggestion> Suggestion { get; set; }
        //public DbSet<tbkkData.Models.Supplier> Supplier { get; set; }
        //public DbSet<tbkkData.Models.UpdateAsset> UpdateAsset { get; set; }
        //public DbSet<tbkkData.Models.UpdateLicense> UpdateLicense { get; set; }
        //public DbSet<tbkkData.Models.UpdateNetwork> UpdateNetwork { get; set; }
        public DbSet<tbkkData.Models.Evaluation> Evaluation { get; set; }
        public DbSet<tbkkData.Models.Detail_Eva> Detail_Eva { get; set; }
        //        public DbSet<tbkkData.Model.Asset_Cock> Asset_Cock { get; set; }
        //        public DbSet<tbkkData.Model.CarType_Cock> CarType_Cock { get; set; }
        //        public DbSet<tbkkData.Model.Company_Cock> Company_Cock { get; set; }
        //        public DbSet<tbkkData.Model.Department_Cock> Department_Cock { get; set; }
        //        public DbSet<tbkkData.Model.DetailOT_Cock> DetailOT_Cock { get; set; }
        //        public DbSet<tbkkData.Model.EmployeeType_Cock> EmployeeType_Cock { get; set; }
        //        public DbSet<tbkkData.Model.Employee_Cock> Employee_Cock { get; set; }
        //        public DbSet<tbkkData.Model.FoodSet_Cock> FoodSet_Cock { get; set; }
        //        public DbSet<tbkkData.Models.GradeHistory_Cock> GradeHistory_Cock { get; set; }
        //        public DbSet<tbkkData.Model.JoinAssetEmp_Cock> JoinAssetEmp_Cock { get; set; }
        //        public DbSet<tbkkData.Model.OT_Cock> OT_Cock { get; set; }
        //        public DbSet<tbkkData.Model.Part_Cock> Part_Cock { get; set; }
        //        public DbSet<tbkkData.Model.Position_Cock> Position_Cock { get; set; }
        //        public DbSet<tbkkData.Model.Repair_Cock> Repair_Cock { get; set; }
        //        public DbSet<tbkkData.Model.Report_Cock> Report_Cock { get; set; }
        //        public DbSet<tbkkData.Model.Supplier_Cock> Supplier_Cock { get; set; }










    }
}
