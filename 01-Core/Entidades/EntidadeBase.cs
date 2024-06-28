namespace Core.Entidades
{
    public abstract class EntidadeBase
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;
        protected EntidadeBase()
        {
            DataCriacao = DateTime.Now;
            DataAlteracao = DateTime.Now;
        }
    }
}
