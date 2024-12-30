using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Spell", menuName = "ScriptableObjects/Spell", order = 2)]
public class Spell : Item
{
    public List<Rune> runes = new List<Rune>(); // all of the runes which comprise the spell
    public int spellLevel = 1;
    public int manaUsage;
    public Sprite spellSprite;
    
    void OnEnable()
    {
        DetermineAttributes();
    }

    // class methods
    public void Cast()
    {
        runes[0].RuneFunction();
    }

    private void DetermineAttributes()
    {
        manaUsage = 0;
        
        int maxLevel = 1;
        int newLevel;
        foreach (Rune r in runes)
        {
            newLevel = r.GetLevel();
            
            if (newLevel > maxLevel) { maxLevel = newLevel; }

            manaUsage += r.GetManaCost();
        }

        spellLevel = maxLevel;
    }
    
    // getter methods
    public int GetManaUsage() { return manaUsage; }

    public Sprite GetSprite()
    {
        return spellSprite; 
    }

    // setter methods
}
