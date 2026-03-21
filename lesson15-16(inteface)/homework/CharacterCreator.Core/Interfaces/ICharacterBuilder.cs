namespace CharacterCreator.Core.Interfaces;

using CharacterCreator.Core.Models;

public interface ICharacterBuilder
{
    public ICharacterBuilder SetRace(string r);
    public ICharacterBuilder SetClass(string c);
    public ICharacterBuilder SetWeapon(string w);
    public ICharacterBuilder SetArmor(string a);
    public Character Build();
}