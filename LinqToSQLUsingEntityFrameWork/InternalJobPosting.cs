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
    
    public partial class InternalJobPosting
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InternalJobPosting()
        {
            this.InternalCandidates = new HashSet<InternalCandidate>();
        }
    
        public string cInternalJobPostingCode { get; set; }
        public string cPositionCode { get; set; }
        public short siNoOfVacancies { get; set; }
        public string vRegion { get; set; }
        public System.DateTime dNoticeReleaseDate { get; set; }
        public Nullable<System.DateTime> dDeadline { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InternalCandidate> InternalCandidates { get; set; }
    }
}
