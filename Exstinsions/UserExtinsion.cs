
using M.Models;

namespace M.Exstinsions;

public static class UserExtinsion
{
    public static UserDto MapToDto(this User user)
    {
        return new UserDto()
        {
            UserName = user.UserName,
            Age = user.Age,
            Email = user.Email,
            Password = user.Password,
            Phone = user.Phone,
            PhotoUrl = user.PhotoUrl
        };
    } 
}