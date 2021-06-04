namespace WebUI.Entity
{
    public interface IUser
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string TcNo { get; set; }
        string Password { get; set; }
        string UserName { get; set; }
    }
}