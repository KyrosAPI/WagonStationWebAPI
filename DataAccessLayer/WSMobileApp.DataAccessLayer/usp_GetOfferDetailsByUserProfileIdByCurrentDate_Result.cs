//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSMobileApp.DataAccessLayer
{
    using System;
    
    public partial class usp_GetOfferDetailsByUserProfileIdByCurrentDate_Result
    {
        public long OfferDetailsId { get; set; }
        public Nullable<System.DateTime> OfferStartDate { get; set; }
        public Nullable<System.DateTime> OfferEndDate { get; set; }
        public string OfferDescription { get; set; }
        public long DealerProfileId { get; set; }
        public string ShopName { get; set; }
        public string ShopAddress { get; set; }
        public string PinCode { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public int BusinessTypeId { get; set; }
        public string BusinessTypeDescription { get; set; }
        public string BusinessTypeCode { get; set; }
        public int BusinessNatureTypeId { get; set; }
        public string BusinessNatureTypeCode { get; set; }
        public string BusinessNatureTypeDescription { get; set; }
        public Nullable<int> Column1 { get; set; }
    }
}
