using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models{

    public class Product{

        [Display(Name = "Ürün Id")]
        public int ProductId { get; set; }

        [Display(Name = "Ürün Adı")]
        [Required(ErrorMessage = "Ürün adı zorunlu!")]
        [StringLength(100)]
        public string? Name {get;set;}  
        [Required]
        [Range(0,100000)]
        public decimal Price {get;set;}
        public string? Image {get;set;} = string.Empty;
        public bool IsActive {get;set;}
        [Required]
        public int? CategoryId {get;set;}
    }
}
