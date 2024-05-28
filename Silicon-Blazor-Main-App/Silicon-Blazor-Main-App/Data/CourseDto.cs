using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Silicon_Blazor_Main_App.Data
{
    public class CourseDto
    {
        [Required]
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal DiscountPrice { get; set; }
        public int Hours { get; set; }
        public bool IsBestSeller { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal LikesInNumbers { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal LikesInProcent { get; set; }
        public string? Author { get; set; }
        public string imageUrl { get; set; } = null!;
    }
}