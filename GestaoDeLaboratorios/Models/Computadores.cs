using System.ComponentModel.DataAnnotations;

namespace GestaoDeLaboratorios.Models
{
    public class Computadores
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Processador { get; set; }
        [Display(Name = "Placa Mãe")]
        [Required]
        public string PlacaMae { get; set; }
        [Display(Name = "Memória")]
        [Required]
        public int Memoria { get; set; }
        [Required]
        public int HD { get; set; }
        [Display(Name = "Número de Patrimônio")]
        [Required]
        public int NumeroPatrimonio { get; set; }
        [Display(Name = "Data de Compra")]
        [Required]
        public DateOnly DataDeCompra { get; set; }

    }
}
