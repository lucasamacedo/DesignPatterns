namespace DesignPatterns2.Cap1
{
    internal class LeitorDeConfiguracao
    {
        private readonly string connectionString = "User Id=root;Password=;Server=localhost;Database=meuBanco";
        public LeitorDeConfiguracao()
        {
        }
        public string LeConnectionString()
        {
            return connectionString;
        }
    }
}