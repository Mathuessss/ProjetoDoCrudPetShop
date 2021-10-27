using System.ComponentModel.DataAnnotations;
namespace Crud_do_petshop.Models
{
    public class Servico
    {
        [Key]
        public int Id { get; set; }
        public string NomeServico { get; set; }
        public string NomeCachorro { get; set; }
        public string Dataservico { get; set; }
        public decimal Preco { get; set; }
    }
}