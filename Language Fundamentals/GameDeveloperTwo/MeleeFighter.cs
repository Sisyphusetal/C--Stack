public class MeleeFighter : Enemy
{
    
    public MeleeFighter (string name) : base(name)
    {
        Name = name;
        Health = 120;
        AttackList = new List<Attack>()
        {
            new Attack("Punch", 20),
            new Attack("Kick", 15),
            new Attack("Tackle", 25),
        };
    }

    public void Rage(Enemy Target)
    {   
        Random rand = new Random();
        string RageAttackName = AttackList[rand.Next(0, AttackList.Count)].Name;
        int RageAttackDamage = AttackList[rand.Next(0, AttackList.Count)].DamageAmount + 10;
        Target.Health = Target.Health - RageAttackDamage;
        Console.WriteLine($"{Name} rages, using {RageAttackName} and dealing {RageAttackDamage}! {Target.Name} now has {Target.Health} health remaining!");
    }
}