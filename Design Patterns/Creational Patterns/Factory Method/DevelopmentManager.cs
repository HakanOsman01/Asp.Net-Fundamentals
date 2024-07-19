namespace Creational_Patterns.Factory_Method
{
    public class DevelopmentManager : HiringManager
    {
        protected override IInterviweir MakeInterviewer()
        {
            return new Developer();
        }
    }
}
