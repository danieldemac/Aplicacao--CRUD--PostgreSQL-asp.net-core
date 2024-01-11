namespace CRUD_PostgreSQL.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name="Código")]
        public int iD { get; set; }

        [Column("Nome")]
        [Display(Name="Nome")]
        public string Nome { get; set; }
    }
}

