using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : Item
{
    private List<Rune> runes = new List<Rune>(); // all of the runes which comprise the spell
    private int spellLevel = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        determineLevel(runes.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // spell level: 1 (1), 3 (2), 4 (3), 6 (4), 7 (5)
    private void determineLevel(int runeCount)
    {
        int maxLevel = 1;
        int newLevel;
        for (int i = 0; i < runeCount; i++)
        {
            newLevel = runes[i].GetLevel();
            
            if (newLevel > maxLevel) { maxLevel = newLevel; }
        }

        spellLevel = maxLevel;
    }
}
