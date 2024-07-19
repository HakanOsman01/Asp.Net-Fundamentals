namespace Ado.Net_Exercise
{
    public static class SqlQuerie
    {
        public const string MinionsVillansCountQuerie = @"SELECT v.Name,COUNT(mv.MinionId) AS [CountNumber]
                FROM Villains AS v INNER JOIN MinionsVillains AS mv
                ON v.Id = mv.VillainId INNER JOIN Minions AS m
                ON mv.MinionId = m.Id
                GROUP BY v.Name,v.Id
            HAVING COUNT(mv.MinionId)>3";
    }
}
