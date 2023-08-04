Enemy Sephiroth = new Enemy("Sephiroth", 100);

Attack Fireball = new Attack("Fireball", 25);
Attack LightningBolt = new Attack("Lightning Bolt", 20);
Attack MagicMissile = new Attack("Magic Missile", 10);

Sephiroth.AttackList.Add(Fireball);
Sephiroth.AttackList.Add(LightningBolt);
Sephiroth.AttackList.Add(MagicMissile);

Sephiroth.RandomAttack();