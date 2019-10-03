namespace DungeonCrawlerVersion61
{
    public class Monster
    {
        public string monsterName { get; set; }
        public int monsterHealth { get; set; }
        public int monsterDamage { get; set; }

        public Monster (string monsterName, int monsterHealth, int monsterDamage)
        {
            this.monsterName = monsterName;
            this.monsterHealth = monsterHealth;
            this.monsterDamage = monsterDamage;
        }
    }
}