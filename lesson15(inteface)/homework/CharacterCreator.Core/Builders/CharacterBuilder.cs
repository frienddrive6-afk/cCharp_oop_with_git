namespace CharacterCreator.Core.Builders;

using CharacterCreator.Core.Interfaces;
using CharacterCreator.Core.Models;

public class HeroBuilder : ICharacterBuilder
{
    private Character _character = new Character();

    public ICharacterBuilder SetRace(string r)
    {
        _character.Race = r;
        return this;
    }

    public ICharacterBuilder SetClass(string c)
    {
        _character.Class = c;
        return this;
    }

    public ICharacterBuilder SetWeapon(string w)
    {
        _character.Weapon = w;
        return this;
    }

    public ICharacterBuilder SetArmor(string a)
    {
        _character.Armor = a;
        return this;
    }

    public Character Build()
    {
        if(_character.Race == null)
            throw new Exception("Missing Race");
        if (_character.Class == null)
            throw new Exception("Missing Class");
        if (_character.Weapon == null)
            throw new Exception("Missing Weapon");
        if (_character.Armor == null)
            throw new Exception("Missing Armor");
        
        Character character = _character;

        _character = new Character();

        return character;
    }
}
