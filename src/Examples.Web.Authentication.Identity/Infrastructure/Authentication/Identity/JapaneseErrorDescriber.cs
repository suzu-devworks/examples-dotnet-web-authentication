using Microsoft.AspNetCore.Identity;

namespace Examples.Web.Authentication.Identity;

public class JapaneseErrorDescriber : IdentityErrorDescriber
{

    public override IdentityError ConcurrencyFailure() => new()
    {
        Code = nameof(ConcurrencyFailure),
        Description = "Optimistic concurrency failure, object has been modified."
    };

    public override IdentityError DefaultError() => new()
    {
        Code = nameof(DefaultError),
        Description = $"An unknown failure has occurred."
    };

    public override IdentityError DuplicateEmail(string email) => new()
    {
        Code = nameof(DuplicateEmail),
        Description = $"Email '{email}' is already taken."
    };

    public override IdentityError DuplicateRoleName(string role) => new()
    {
        Code = nameof(DuplicateRoleName),
        Description = $"Role name '{role}' is already taken."
    };

    public override IdentityError DuplicateUserName(string userName) => new()
    {
        Code = nameof(DuplicateUserName),
        Description = $"User Name '{userName}' is already taken."
    };

    public override IdentityError InvalidEmail(string email) => new()
    {
        Code = nameof(InvalidEmail),
        Description = $"Email '{email}' is invalid."
    };

    public override IdentityError InvalidRoleName(string role) => new()
    {
        Code = nameof(InvalidRoleName),
        Description = $"Role name '{role}' is invalid."
    };

    public override IdentityError InvalidToken() => new()
    {
        Code = nameof(InvalidToken),
        Description = "Invalid token."
    };

    public override IdentityError InvalidUserName(string userName) => new()
    {
        Code = nameof(InvalidUserName),
        Description = $"User name '{userName}' is invalid, can only contain letters or digits."
    };

    public override IdentityError LoginAlreadyAssociated() => new()
    {
        Code = nameof(LoginAlreadyAssociated),
        Description = "A user with this login already exists."
    };

    public override IdentityError PasswordMismatch() => new()
    {
        Code = nameof(PasswordMismatch),
        Description = "Incorrect password."
    };

    public override IdentityError PasswordRequiresDigit() => new()
    {
        Code = nameof(PasswordRequiresDigit),
        Description = "Passwords must have at least one digit ('0'-'9')."
    };

    public override IdentityError PasswordRequiresLower() => new()
    {
        Code = nameof(PasswordRequiresLower),
        Description = "Passwords must have at least one lowercase ('a'-'z')."
    };

    public override IdentityError PasswordRequiresNonAlphanumeric() => new()
    {
        Code = nameof(PasswordRequiresNonAlphanumeric),
        Description = "password must have at least one non alphanumeric character."
    };

    public override IdentityError PasswordRequiresUniqueChars(int uniqueChars) => new()
    {
        Code = nameof(PasswordRequiresUniqueChars),
        Description = "Passwords must use at least {0} different characters."
    };

    public override IdentityError PasswordRequiresUpper() => new()
    {
        Code = nameof(PasswordRequiresUpper),
        //Description = "Passwords must have at least one uppercase ('A'-'Z')."
        Description = "パスワードには少なくとも 1 つの大文字が必要です。 ('A'-'Z')."
    };

    public override IdentityError PasswordTooShort(int length) => new()
    {
        Code = nameof(PasswordTooShort),
        Description = $"password must be at least {length} characters."
    };

    public override IdentityError RecoveryCodeRedemptionFailed() => new()
    {
        Code = nameof(RecoveryCodeRedemptionFailed),
        Description = "Recovery code redemption failed."
    };

    public override IdentityError UserAlreadyHasPassword() => new()
    {
        Code = nameof(UserAlreadyHasPassword),
        Description = "User already has a password set."
    };

    public override IdentityError UserAlreadyInRole(string role) => new()
    {
        Code = nameof(UserAlreadyInRole),
        Description = $"User already in role '{role}'."
    };

    public override IdentityError UserLockoutNotEnabled() => new()
    {
        Code = nameof(UserLockoutNotEnabled),
        Description = "Lockout is not enabled for this user."
    };

    public override IdentityError UserNotInRole(string role) => new()
    {
        Code = nameof(UserNotInRole),
        Description = $"User is not in role '{role}'."
    };

}
