namespace Struvtural_Patterns.FlyWeight
{
    public class TeaMaker 
    {
        private Dictionary<string, KarakTea> Teamaker;
        public TeaMaker()
        {
            Teamaker = new Dictionary<string, KarakTea>();
        }
        public KarakTea Make(string preference)
        {
            if(!Teamaker.ContainsKey(preference))
            {
                Teamaker[preference] = new KarakTea();
            }
            return Teamaker[preference];
        }

    }
}
