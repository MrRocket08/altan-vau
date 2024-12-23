using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : Item
{
    private List<Component> spellComponents = new List<Component>(); // all of the components which comprise the spell
    private int spellLevel = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        determineLevel(spellComponents.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // spell level: 1 (1), 3 (2), 4 (3), 6 (4), 7 (5)
    private void determineLevel(int componentCount)
    {
        switch (componentCount)
        {
            case 1: spellLevel = 1; break;
            case 2: spellLevel = 2; break;
            case 3: spellLevel = 2; break;
            case 4: spellLevel = 3; break;
            case 5: spellLevel = 4; break;
            case 6: spellLevel = 4; break;
            case 7: spellLevel = 5; break;
        }
    }
}
