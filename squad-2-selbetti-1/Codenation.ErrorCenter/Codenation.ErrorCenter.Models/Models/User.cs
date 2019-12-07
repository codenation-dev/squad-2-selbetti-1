using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Codenation.ErrorCenter.Models
{
    [Table("user")]
    public class User
    {
        [Column("id")]
        [Key]
        public long Id { get; set; }

        [Column("name")]
        [StringLength(255)]
        [Required]
        public long Name { get; set; }

        [Column("email")]
        [StringLength(255)]
        [Required]
        public long Email { get; set; }

        [Column("password")]
        [StringLength(255)]
        [Required]
        public string Password { get; set; }
    }
}
