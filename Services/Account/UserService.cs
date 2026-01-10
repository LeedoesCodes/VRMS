using VRMS.Enums;
using VRMS.Helpers.Security;
using VRMS.Models.Accounts;
using VRMS.Repositories.Accounts;

namespace VRMS.Services.Account;

public class UserService
{
    private readonly UserRepository _userRepo;

    public UserService(UserRepository userRepo)
    {
        _userRepo = userRepo;
    }

    // ----------------------------
    // AUTHENTICATION
    // ----------------------------

    public User Authenticate(
        string username,
        string plainPassword)
    {
        var user =
            _userRepo.GetForAuthentication(username);

        if (!Password.Verify(
                plainPassword,
                user.PasswordHash))
            throw new InvalidOperationException(
                "Invalid password.");

        return user;
    }

    // ----------------------------
    // CREATE USER
    // ----------------------------

    public int CreateUser(
        string username,
        string plainPassword,
        UserRole role,
        bool isActive = true)
    {
        if (string.IsNullOrWhiteSpace(username))
            throw new InvalidOperationException(
                "Username cannot be empty.");

        var hash = Password.Hash(plainPassword);

        return _userRepo.Create(
            username,
            hash,
            role,
            isActive);
    }

    // ----------------------------
    // LOOKUPS
    // ----------------------------

    public User GetById(int userId)
        => _userRepo.GetById(userId);

    public User GetByUsername(string username)
        => _userRepo.GetByUsername(username);

    // ----------------------------
    // DEACTIVATE
    // ----------------------------

    public void Deactivate(int userId)
        => _userRepo.Deactivate(userId);

    // ----------------------------
    // PASSWORD MANAGEMENT
    // ----------------------------

    public void ChangePassword(
        int userId,
        string currentPlainPassword,
        string newPlainPassword)
    {
        var user = _userRepo.GetById(userId);

        if (!Password.Verify(
                currentPlainPassword,
                user.PasswordHash))
            throw new InvalidOperationException(
                "Current password is incorrect.");

        var newHash =
            Password.Hash(newPlainPassword);

        _userRepo.UpdatePassword(
            userId,
            newHash);
    }

    // ----------------------------
    // PROFILE MANAGEMENT
    // ----------------------------

    public void UpdateUserProfile(
        int userId,
        string username,
        UserRole role,
        bool isActive)
    {
        if (string.IsNullOrWhiteSpace(username))
            throw new InvalidOperationException(
                "Username cannot be empty.");

        _userRepo.UpdateProfile(
            userId,
            username,
            role,
            isActive);
    }
}
