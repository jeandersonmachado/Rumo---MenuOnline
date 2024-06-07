using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MenuOnline.Models
{
    [Table("Pratos")]
    public class Prato
    {
        [Key]
        public int PratoId { get; set; }

        [Required(ErrorMessage = "O nome do prato deve ser informado")]
        [Display(Name = "Nome do prato")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O valor deve estar entre 10 e 80")]
        public string Nome { get; set;}

        [Required(ErrorMessage ="Informe o preço do lanche")]
        [Display(Name = "Preço")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1,999.99, ErrorMessage ="O preço deve estar entre 1 e 999,99")]
        public decimal Preco {  get; set;}

        [Required(ErrorMessage = "Descrição do prato deve ser informada")]
        [Display(Name = "Descrição do prato")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "O valor deve estar entre 10 e 200")]
        public string Descricao { get; set;}


        public int CategoriaId { get; set;}
        public virtual Categoria Categoria { get; set;}
    }
}
