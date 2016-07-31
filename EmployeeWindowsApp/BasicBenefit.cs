namespace EmployeeWindowsApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BasicBenefit
    {
        public int Id { get; set; }

        public string BenefitName { get; set; }

        public int? Benefits_Id { get; set; }

        public virtual Benefit Benefit { get; set; }
    }
}
