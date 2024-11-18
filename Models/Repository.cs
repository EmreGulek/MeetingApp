using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Models;

public static class Repository
{
    private static List<UserInfo> _users = new();

    static Repository()
    {
        _users.Add(new UserInfo()
            { Id = 1, Name = "Fatih", Email = "fatih@gmail.com", Phone = "5551834943", WillAttend = true });
        _users.Add(new UserInfo()
            { Id = 2, Name = "Enes", Email = "enes@gmail.com", Phone = "5551834948", WillAttend = true });
        _users.Add(new UserInfo()
            { Id = 3, Name = "Ali", Email = "Ali@gmail.com", Phone = "5551834940", WillAttend = true });
    }

    public static List<UserInfo> Users
    {
        get { return _users; }
    }

    public static void CreateUser(UserInfo user)
    {
        user.Id = Users.Count + 1;
        _users.Add(user);
    }

    public static UserInfo? GetById(int id)
    {
        return _users.FirstOrDefault(user => user.Id == id);
    }




}