namespace CharacterCreator.Core.Models;



public class Character
{
    public string? Race {get; set; }
    public string? Class {get; set; }
    public string? Weapon {get; set; }
    public string? Armor {get; set; }

    public override string ToString()
    {
        return $"Race: {Race}\nClass: {Class}\nWeapon: {Weapon}\nArmor: {Armor}";
    }
}