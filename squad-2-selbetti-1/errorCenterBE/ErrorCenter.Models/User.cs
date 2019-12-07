using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace errorCenter.Models
{
    [Table("user")]
    class User
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
