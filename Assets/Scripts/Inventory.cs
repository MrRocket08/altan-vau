using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Spell[] spellList = new Spell[6];

    // getter methods
    
    // setter methods
    public bool AddSpell(Spell spell)
    {
        for (int i = 0; i < spellList.Length; i++)
        {
            if (spellList[i] == null)
            {
                spellList[i] = spell;
                return true;
            }
        }
        
        return false;
    }
}
