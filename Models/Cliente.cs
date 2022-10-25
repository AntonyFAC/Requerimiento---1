namespace rt.Models
{
    public class Cliente
    {
        public Cliente(String id, String name, String email)
        {
            this.id = id;
            this.name = name;
            this.email = email;
        }
        public String id { get; set; }
        public String? name { get; set; }
        public String? email { get; set; }

    }
}