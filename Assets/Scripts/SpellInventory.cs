using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellInventory : MonoBehaviour
{
    public Spell[] spells = new Spell[6];
    public SpellSlot[] spellSlots = new SpellSlot[6];

    private SpellSlot selectedSpellSlot;
    private Spell selectedSpell;
    
    // event methods
    void Start()
    {
        UpdateSpellSlots();
    }
    
    // class methods    
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

    public void SelectSpellSlot(int slotNumber)
    {
        selectedSpellSlot = spellSlots[slotNumber];
        selectedSpell = selectedSpellSlot.GetSpell();

        for (int i = 0; i < spellSlots.Length; i++)
        {
            if (i == slotNumber)
            {
                spellSlots[i].HighlightSpellSlot();
            }
            else
            {
                spellSlots[i].DehighlightSpellSlot();
            }
        }
    }

    public Spell UseSpellSlot()
    {
        selectedSpell.Cast();
        
        return selectedSpell;
    }

    private void UpdateSpellSlots()
    {
        foreach (SpellSlot s in spellSlots)
        {
            s.UpdateSpellSlot();
        }
    }

    public void AddSpell(Spell spell)
    {
        bool isAdded = Add(spell);
        
        if (isAdded)
        {
            UpdateSpellSlots();
        }
    }
}
