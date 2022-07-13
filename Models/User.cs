using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GenerateDB.Models
{
    public partial class User
    {
        [Key]
        [StringLength(50)]
        public string account { get; set; }
        [Required]
        [StringLength(50)]
        public string password { get; set; }
        [StringLength(50)]
        public string name { get; set; }
        [StringLength(50)]
        public string email { get; set; }
        public bool is_active { get; set; }
        [StringLength(10)]
        public string update_by { get; set; }
        [StringLength(10)]
        public string update_time { get; set; }
    }
}
