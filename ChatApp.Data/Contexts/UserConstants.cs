namespace ChatApp.Data.Contexts;

public class UserConstants
{
    public static List<User> users = new List<User>()
        {
            new User() { Id = 1, UserName="lqmanh1997", Password= "1", Role="admin"},
            new User() { Id = 2, UserName="lqcuong", Password= "1", Role="customer"},
        };
}

