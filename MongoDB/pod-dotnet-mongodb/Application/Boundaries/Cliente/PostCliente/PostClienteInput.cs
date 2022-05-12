using System;

namespace Application.Boundaries.Cliente.PostCliente
{
    public class PostClienteInput
    {
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public string ZipCode { get; set; }
    }
}
