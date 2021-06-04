namespace WebUI.Entity
{
    public class Admin:IUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNo { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
    }
}