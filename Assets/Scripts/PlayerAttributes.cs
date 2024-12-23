using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttributes : MonoBehaviour
{
    private int STR = 12; // used for all typical strength checks as well as CON
    private int DEX = 12; // used for quickly casting complex spells and wielding staffs
    private int INT = 12; // used for weapon attunement speed and mana usage
    private int WIS = 12; // used for spell and component attunement speed and spell complexity

    #region mana

        private float MAX_MANA = 150;
        private float mana = 0;
        
        private float MAX_MANA_REGEN = 30; // mana regen takes longer to increase if more mana was used by the spell
        private float manaRegen = 0;

        private float timeSinceSpellUsage = 0f; // using any spell reduces this back to 0
        private float waitTimeToRegen = 0f; // a larger amount of mana used by the spell results in a larger time to start regenning
        private float regenExponential = 15f; // the constant c in y = c * log(x)

    #endregion
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceSpellUsage += Time.deltaTime;
        
        RestoreMana(MAX_MANA - mana, timeSinceSpellUsage);
    }

    private void RestoreMana(float manaDifference, float time)
    {
        if (timeSinceSpellUsage >= waitTimeToRegen)
        {
            manaRegen = Mathf.Clamp(regenExponential * Mathf.Log(timeSinceSpellUsage - waitTimeToRegen), 0, MAX_MANA_REGEN);
        }
        else
        {
            manaRegen = 0f;
        }

        mana += manaRegen;
    }

    public void UseSpell(float manaUsage)
    {
        timeSinceSpellUsage = 0f;
        waitTimeToRegen = manaUsage / 10f;
    }
}
