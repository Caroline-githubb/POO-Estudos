using System.Text;

namespace Ex_Fixacao08.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDateTime { get; set; }

        public Client()
        {   

        }

        public Client(string name, string email, DateTime birthDateTime)
        {
            Name = name;
            Email = email;
            BirthDateTime = birthDateTime;
        }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + " (" + BirthDateTime.ToString("dd/MM/yyyy") + ") - "+Email);
            return sb.ToString();            
        }
       
    }
}