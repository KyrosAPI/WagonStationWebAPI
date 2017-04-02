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
    using System.Collections.Generic;
    
    public partial class CarDetail
    {
        public CarDetail()
        {
            this.ServiceRequests = new HashSet<ServiceRequest>();
            this.CarPictures = new HashSet<CarPicture>();
        }
    
        public long CarDetailsId { get; set; }
        public long UserProfileId { get; set; }
        public string CarName { get; set; }
        public string CarModelName { get; set; }
        public string NumberPlate { get; set; }
        public int CarMakeYear { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        public virtual ICollection<ServiceRequest> ServiceRequests { get; set; }
        public virtual UserProfile UserProfile { get; set; }
        public virtual ICollection<CarPicture> CarPictures { get; set; }
    }
}