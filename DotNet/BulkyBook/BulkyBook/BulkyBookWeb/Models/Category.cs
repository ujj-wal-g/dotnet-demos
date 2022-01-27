
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Category
    {
       [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        //[DisplayName("Display order")]
        //[Range(1,100,ErrorMessage ="")]
        public int DisplayOrder{ get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
        public int Age { get; set; }

    }
}
