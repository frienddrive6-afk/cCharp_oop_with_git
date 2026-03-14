using CharacterCreator.Core.Builders;
using CharacterCreator.Core.Models;
using CharacterCreator.Core.Interfaces;


var builder = new HeroBuilder();
var director = new CharacterDirector(builder);

director.ConstructWarrior();
Character warrior = builder.Build();
Console.WriteLine(warrior);

Console.WriteLine();

director.ConstructMage();
Character mage = builder.Build();
Console.WriteLine(mage);


//or
System.Console.WriteLine();
ICharacterBuilder characterBuilder = new HeroBuilder();
Character character = characterBuilder
   .SetRace("Elf")
   .SetClass("Mage")
   .SetWeapon("Staff")
   .SetArmor("Cloth")
   .Build();

Console.WriteLine(character);
