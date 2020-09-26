namespace Adventures.Model
{
    public class RespEmpresa
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public override string ToString()
        {
            return this.Nome;
        }

    }
}