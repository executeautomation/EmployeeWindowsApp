namespace EmployeeWindowsApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Benefit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Benefit()
        {
            BasicBenefits = new HashSet<BasicBenefit>();
        }

        public int Id { get; set; }

        public int? Employee_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BasicBenefit> BasicBenefits { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
