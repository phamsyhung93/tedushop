namespace TeduShop.Model.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IdentityUserLogin
    {
        [Key]
        public string UserId { get; set; }

        public string LoginProvider { get; set; }

        public string ProviderKey { get; set; }

        [StringLength(128)]
        public string ApplicationUser_Id { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
