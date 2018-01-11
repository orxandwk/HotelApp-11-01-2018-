//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rooms
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rooms()
        {
            this.Rooms_Details = new HashSet<Rooms_Details>();
            this.Rooms_Photos = new HashSet<Rooms_Photos>();
        }
    
        public int id { get; set; }
        public int room_number { get; set; }
        public int room_type_id { get; set; }
        public int bed_count { get; set; }
        public int room_price { get; set; }
        public bool room_reservation_status { get; set; }
        public bool room_cleaning_status { get; set; }
        public bool room_status { get; set; }
    
        public virtual Room_Types Room_Types { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rooms_Details> Rooms_Details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rooms_Photos> Rooms_Photos { get; set; }
    }
}