//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FarmManagementSoftware.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class HEO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HEO()
        {
            this.CT_PHIEUHEO = new HashSet<CT_PHIEUHEO>();
            this.LICHPHOIGIONGs = new HashSet<LICHPHOIGIONG>();
            this.LICHPHOIGIONGs1 = new HashSet<LICHPHOIGIONG>();
            this.LICHTIEMHEOs = new HashSet<LICHTIEMHEO>();
        }
    
        public string MaHeo { get; set; }
        public string MaLoaiHeo { get; set; }
        public string MaGiongHeo { get; set; }
        public string GioiTinh { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public Nullable<int> TrongLuong { get; set; }
        public string MaChuong { get; set; }
        public string MaHeoCha { get; set; }
        public string MaHeoMe { get; set; }
        public string NguonGoc { get; set; }
        public string TinhTrang { get; set; }
    
        public virtual CHUONGTRAI CHUONGTRAI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEUHEO> CT_PHIEUHEO { get; set; }
        public virtual GIONGHEO GIONGHEO { get; set; }
        public virtual LOAIHEO LOAIHEO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LICHPHOIGIONG> LICHPHOIGIONGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LICHPHOIGIONG> LICHPHOIGIONGs1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LICHTIEMHEO> LICHTIEMHEOs { get; set; }
    }
}
