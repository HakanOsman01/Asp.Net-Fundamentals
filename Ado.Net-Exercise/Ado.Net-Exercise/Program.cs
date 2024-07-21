using Microsoft.Data.SqlClient;

namespace Ado.Net_Exercise
{
    internal class Program
    {
        private static string[] elements;
        static void Main(string[] args)
        {
            const string connectionsString = @"Server=(LocalDB)\MSSQLLocalDB;Database=MinionsDB;Trusted_Connection=True;";
            SqlConnection sqlConnection = new SqlConnection(connectionsString);
            GetNumberOfVillains(sqlConnection);
            elements=Console.ReadLine().Split(' ').ToArray();
          
            
           


        }

        private static void GetPermute(int idx)
        {
           if(idx>=elements.Length)
           {
                Console.WriteLine(string.Join(' ',elements));
                return;
           }
           GetPermute(idx + 1);
          var set =  new HashSet<string>() { elements[idx] };
           for (int i = idx+1; i < elements.Length; i++)
           {
                if (!set.Contains(elements[i]))
                {
                    Swap(idx, i);
                    GetPermute(idx + 1);
                    Swap(idx, i);
                }
              

           }
        }

        private static void Swap(int firstIndex, int secondIndex)
        {
            var temp = elements[firstIndex];
            elements[firstIndex] = elements[secondIndex];
            elements[secondIndex] = temp;
           
        }

        private  static void GetNumberOfVillains(SqlConnection sqlConnection)
        {

            using (sqlConnection)
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(SqlQuerie.MinionsVillansCountQuerie, sqlConnection);
                using (cmd)
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader[0]} – {reader[1]}");
                    }
                }
            }
        }

    }
}