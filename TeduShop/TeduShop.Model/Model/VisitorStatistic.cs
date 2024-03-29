namespace TeduShop.Model.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VisitorStatistic
    {
        public Guid ID { get; set; }

        public DateTime VisitedDate { get; set; }

        [StringLength(50)]
        public string IPAddress { get; set; }
    }
}
