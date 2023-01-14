namespace StoreAPI.Models
{
    public class User
    {
        public string Name { get; set; }
        public string eMail { get; set; }
        public string Password { get; set; }
        public Boolean Administrator = false;
    }
}
