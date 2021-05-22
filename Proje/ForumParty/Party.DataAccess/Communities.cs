//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Party.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Communities
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Communities()
        {
            this.Posts = new HashSet<Posts>();
            this.UsersCommunity = new HashSet<UsersCommunity>();
        }
    
        public int CommunityID { get; set; }
        public string CommunityName { get; set; }
        public string Description { get; set; }
        public byte[] CommunityImage { get; set; }
        public Nullable<int> MembersCount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Posts> Posts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersCommunity> UsersCommunity { get; set; }
    }
}
