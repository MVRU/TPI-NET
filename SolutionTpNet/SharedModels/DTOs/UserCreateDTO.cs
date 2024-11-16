using SharedModels.Enums;

namespace SharedModels.DTOs
{
    public class UserCreateDTO
    {
        public int File { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public UserRole UserRole { get; set; }
    }
}