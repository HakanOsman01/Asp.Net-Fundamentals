namespace Struvtural_Patterns.FlyWeight
{
    public class TeaShop
    {
        private Dictionary<int, KarakTea> orders;
        private readonly TeaMaker teaMaker;
        public TeaShop(TeaMaker teaMaker)
        {
            orders = new Dictionary<int, KarakTea>();
            this.teaMaker = teaMaker;
            
        }
        public void TakeOrder(string teaType, int table)
        {
            orders[table] = teaMaker.Make(teaType);
        }

        public void Serve()
        {
            foreach (var table in orders.Keys)
            {
                Console.WriteLine($"Serving Tea to table # {table}");
            }
        }

    }
}
