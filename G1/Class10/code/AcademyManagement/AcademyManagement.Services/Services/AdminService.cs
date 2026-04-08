using AcademyManagement.Domain;
using AcademyManagement.Domain.Enums;
using AcademyManagement.Domain.Models;

namespace AcademyManagement.Services.Services;

public class AdminService
{
    private DataAccess _dataAccess;
    public AdminService()
    {
        _dataAccess = new DataAccess();
    }

    //Login
    public Admin? AdminLogin(string username, string password)
    {
        Admin? adminFromDb = _dataAccess.GetAdmin(username, password);
        if(adminFromDb == null)
        {
            throw new Exception("Invalid credentials. Try again!");
        }
        return adminFromDb;
    }

    //CreateUser
    public void CreateUser(string firstName, string lastName, string age, string username, string password, Role role)
    {
        bool userExists = _dataAccess.CheckIfUserExsists(username, role);
        if (userExists)
        {
            throw new Exception($@"{role.ToString()} with ""{username}"" already exists!");
        }
        _dataAccess.CreateNewUser(firstName, lastName, age, username, password, role);

    }

    //DeleteUser
    public void DeleteUser(string username, Role role)
    {
        bool userExists = _dataAccess.CheckIfUserExsists(username, role);
        if (!userExists)
        {
            throw new Exception($"Cannot delete user that doesn't exists!");
        }
        _dataAccess.DeleteUser(username, role);
    }

    //GetUsersToRemove
    public List<string> GetUSersToRemove(Role role, Admin loggedAdmin)
    {
        return _dataAccess.GetUsernames(role, loggedAdmin);
    }

}
