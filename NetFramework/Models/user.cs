namespace ApiBasicCrudNetFramework.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user
    {
        public int id { get; set; }

        [Column(TypeName = "text")]
        public string username { get; set; }

        [Column(TypeName = "text")]
        public string password { get; set; }
    }
}
