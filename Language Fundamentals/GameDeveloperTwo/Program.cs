Enemy Sephiroth = new Enemy("Sephiroth", 100);
MeleeFighter Barbaros = new MeleeFighter("Barbaros", 120);
RangedFighter Legolas = new RangedFighter("Legolas", 100);
MagicCaster Elminster = new MagicCaster("Elminster", 80);

Attack Fireball = new Attack("Fireball", 25);
Attack LightningBolt = new Attack("Lightning Bolt", 20);
Attack StaffStrike = new Attack("Staff Strike", 10);

Attack Punch = new Attack("Punch", 20);
Attack Kick = new Attack("Kick", 15);
Attack Tackle = new Attack("Tackle", 25);

Attack ShootArrow = new Attack("Shoot an arrow", 20);
Attack ThrowKnife = new Attack("Throw a knife", 15);


MeleeFighter.AttackList.Add(Punch);
MeleeFighter.AttackList.Add(Kick);
MeleeFighter.AttackList.Add(Tackle);

MagicCaster.AttackList.Add(Fireball);
MagicCaster.AttackList.Add(LightningBolt);
MagicCaster.AttackList.Add(StaffStrike);


