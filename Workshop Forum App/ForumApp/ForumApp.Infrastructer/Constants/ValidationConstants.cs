namespace ForumApp.Infrastructer.Constants
{
    /// <summary>
    /// Validation Constans
    /// </summary>
    public static class ValidationConstants
    {
        /// <summary>
        /// Title Max Lenght
        /// </summary>
        public const int TitleMaxLenght = 50;
        /// <summary>
        /// Title Min Lenght
        /// </summary>
        public const int TitleMinLenght = 10;
        /// <summary>
        /// Context Max Lenght
        /// </summary>
        public const int ContextMaxLenght = 1500;
        /// <summary>
        /// Conten Min Lenght
        /// </summary>
        public const int ContextMinLenght = 30;
        /// <summary>
        /// This is the required message
        /// </summary>
        public const string RequiredErrorMessage = "The {0} field is required!!!";
        public const string StringLenghtErrorMessage = "The {0} field must be " +
            "betweem {2} and {1}";


    }
}
