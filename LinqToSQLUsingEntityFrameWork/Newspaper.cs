//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinqToSQLUsingEntityFrameWork
{
    using System;
    using System.Collections.Generic;
    
    public partial class Newspaper
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Newspaper()
        {
            this.NewsAds = new HashSet<NewsAd>();
        }
    
        public string cNewspaperCode { get; set; }
        public string cNewspaperName { get; set; }
        public string vRegion { get; set; }
        public string vTypeOfNewspaper { get; set; }
        public string vContactPerson { get; set; }
        public string vHOAddress { get; set; }
        public string cCity { get; set; }
        public string cState { get; set; }
        public string cZip { get; set; }
        public string cCountryCode { get; set; }
        public string cFax { get; set; }
        public string cPhone { get; set; }
    
        public virtual Country Country { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewsAd> NewsAds { get; set; }
    }
}
