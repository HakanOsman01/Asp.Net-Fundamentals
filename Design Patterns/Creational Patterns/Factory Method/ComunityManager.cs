namespace Creational_Patterns.Factory_Method
{
    public class ComunityManager : HiringManager
    {
        protected override IInterviweir MakeInterviewer()
        {
            return new Community();
        }
    }
}
