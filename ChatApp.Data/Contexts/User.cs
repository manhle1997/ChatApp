namespace ChatApp.Data.Contexts;

public partial class User
{
    public long Id { get; set; }

    public string UserName { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public string Password { get; set; } = null!;

    public string? Role { get; set; }
}
