using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_DTO
{
    public class Item_DTO
    {
        public Int64 ItemNumber { get; set; }

        public String ItemCode { get; set; }
        public String ItemDescription { get; set; }
        public String ItemPartNumber { get; set; }
        public String InnerDia  { get; set; }
        public String OuterDia { get; set; }
        public String Thickness { get; set; }
        public String Length { get; set; }
        public String Spec { get; set; }
        public String MaterialGrade { get; set; }
        public Int64 ItemGroup { get; set; }
        public Int64 ItemCategory { get; set; }
        public Int64 ItemSubCategory { get; set; }
        public Int64 MaterialSegregation { get; set; }
        public Int64 PurchaseWarehouse { get; set; }
        public Int64 SaleWarehouse { get; set; }
        public Int64 HSN_Code { get; set; }
        public Int64 UoM { get; set; }
        public Int64 PurchaseUnit { get; set; }
        public Int64 ProductionUnit { get; set; }
        public Int64 SaleUnit { get; set; }
        public Int32 Rights { get; set; }
        public Int32 CreatorCode { get; set; }
        public Int32 Id { get; set; }


        //GridView

        public String Search { get; set; }
        public Int64 UnitConversionNumber { get; set; }
        public Double FromQty { get; set; }
        public Int64 FromUnit { get; set; }
        public Double ToQty { get; set; }
        public Int64 ToUnit { get; set; }
    }
}