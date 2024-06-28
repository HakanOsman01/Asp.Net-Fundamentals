using Microsoft.AspNetCore.Identity;

namespace TaskBoardApp.Data.Configuretion
{
    public static class ConfigurationHelper
    {
       public static IdentityUser testUser = GetUser();

        public static Board openBoard { get; set; } = new Board()
        {
            Id = 1,
            Name = "Open",

        };
        public static Board inProgressBoard = new Board()
        {
            Id = 2,
            Name = "In Progress"
        };
        public static Board doneBoard = new Board()
        {
            Id = 3,
            Name = "Done Board"

        };
        private static IdentityUser GetUser()
        {
            var hasher = new PasswordHasher<IdentityUser>();
            var newUser = new IdentityUser()
            {
                UserName = "test@softuni.bg",
                NormalizedUserName = "TEST@SOFTUNI.BG"


            };
            newUser.PasswordHash = hasher.HashPassword(newUser, "softuni");
            return newUser;
        }
    }
}
