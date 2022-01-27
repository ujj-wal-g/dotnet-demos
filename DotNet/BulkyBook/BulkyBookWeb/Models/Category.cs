﻿
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BulkyBookWeb.Models
{
    public class Category
    {
       [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display order")]
        [Range(1, 100,ErrorMessage="Display order must between 1 to 100!!")]
        public int DisplayOrder{ get; set; }
        
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}
