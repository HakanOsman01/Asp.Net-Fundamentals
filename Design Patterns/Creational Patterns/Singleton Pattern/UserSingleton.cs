namespace Creational_Patterns.Singleton_Pattern
{
    public class UserSingleton
    {
        private static UserSingleton instance;
        private static object isLosk  = new object();
        private UserSingleton() 
        
        {
            Console.WriteLine("Initial");
        }
        public static  UserSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (isLosk)
                    {
                        if (instance == null)
                        {
                            return instance = new UserSingleton();
                        }
                    }


                }
                
                return instance;
            }
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public void ChangePassword(string newPassword)
        {
            this.Password = newPassword;
        }
        public override string ToString()
        {
            return $"I am {UserName} with password:{Password}";
        }

    }
}
