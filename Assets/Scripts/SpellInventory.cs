using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellInventory : MonoBehaviour
{
    public Spell[] spells = new Spell[6];
    public SpellSlot[] spellSlots = new SpellSlot[6];
    
    // getter methods
    
    // setter methods
    private bool Add(Spell spell)
    {
        for (int i = 0; i < spells.Length; i++)
        {
            if (spells[i] == null)
            {
                spells[i] = spell;
                spellSlots[i].SetSpell(spell);
                return true;
            }
        }
        
        return false;
    }

    public void UpdateSpellSlot()
    {
        for (int i = 0; i < spellSlots.Length; i++)
        {
            spellSlots[i].UpdateSpellSlot();
        }
    }

    public void AddSpell(Spell spell)
    {
        bool isAdded = Add(spell);
        
        if (isAdded)
        {
            UpdateSpellSlot();
        }
    }
}
