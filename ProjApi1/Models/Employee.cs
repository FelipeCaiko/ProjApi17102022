namespace ProjApi1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public float Salario { get; set; }
        public Address Address { get; set; }

    }
}
