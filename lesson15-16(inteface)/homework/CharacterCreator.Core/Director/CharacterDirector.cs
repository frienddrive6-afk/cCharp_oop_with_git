namespace CharacterCreator.Core.Builders;

using CharacterCreator.Core.Interfaces;
using CharacterCreator.Core.Models;

public class CharacterDirector
{
    private readonly ICharacterBuilder _builder;
    public CharacterDirector(ICharacterBuilder builder)
    {
        _builder = builder;
    }

    public void ConstructWarrior()
    {
        _builder.SetRace("Human")
            .SetClass("Warrior")
            .SetWeapon("Sword")
            .SetArmor("Leather");
    }

    public void ConstructMage()
    {
        _builder.SetRace("Elf")
            .SetClass("Mage")
            .SetWeapon("Staff")
            .SetArmor("Cloth");
    }
}