using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SpellSlot : MonoBehaviour
{
    private Spell spell;
    private Button slotButton;
    private bool selected = false;
    
    [SerializeField]
    public Image spellImage;
    
    // class methods
    private void Start()
    {
        slotButton = this.GameObject().GetComponent<Button>();
    }
    
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

    public void HighlightSpellSlot()
    {
        slotButton.Select();
    }

    public void DehighlightSpellSlot()
    {
        slotButton.OnDeselect(null);
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
