public class Enemy
{
    public string Name;
    public int Health;
    public List<Attack> AttackList;


    public Enemy(string name, int health)
    {
        Name = name;
        Health = health;
        AttackList = new List<Attack>();
    }

    public void RandomAttack()
    {
        Random rand = new Random();
        Console.WriteLine($"{Name} uses {AttackList[rand.Next(0, AttackList.Count)].Name}");
    }
}
