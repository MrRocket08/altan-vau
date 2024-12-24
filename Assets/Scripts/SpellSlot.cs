using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellSlot : MonoBehaviour
{
    private Spell spell;
    private Image spellImage;

    // class methods
    public void UpdateSpellSlot()
    {
        if (spell != null)
        {
            spellImage.sprite = spell.GetSprite();
            spellImage.enabled = true;
        }
        else
        {
            spellImage.enabled = false;
        }
    }
    
    // getter methods
    public Image GetImage() { return spellImage; }
    public Spell GetSpell() { return spell; }
    
    // setter methods
    public void SetSpell(Spell _spell)
    {
        spell = _spell;
    }

    public void SetImage(Image image)
    {
        spellImage = image;
    }
}
