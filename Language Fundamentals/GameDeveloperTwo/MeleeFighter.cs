public class MeleeFighter : Enemy
{
    
    public MeleeFighter (string name, int health)
    {
        Name = name;
        Health = health;
        AttackList = new List<Attack>();
    }

    public void Rage(Enemy Target)
    {   
        Random rand = new Random();
        string RageAttackName = AttackList[rand.Next(0, AttackList.Count)].Name;
        int RageAttackDamage = AttackList[rand.Next(0, AttackList.Count)].DamageAmount + 10;
        Target.Health - RageAttackDamage;
        Console.WriteLine($"{MeleeFighter.Name} rages, using {RageAttackName} and dealing {RageAttackDamage}! {Target} now has {Target.Health} health remaining!")
    }
}