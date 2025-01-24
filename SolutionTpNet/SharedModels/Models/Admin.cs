namespace SharedModels.Models
{
    public class Admin
    {
        public int Id { get; set; }
        required public string Name { get; set; }
        required public string LastName { get; set; }
        required public string Email { get; set; }
        required public string Password { get; set; }
        public string? Position { get; set; } // Opcional

    }
}