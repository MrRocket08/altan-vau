using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Item : ScriptableObject
{
	private int rarity = 1;
	private Sprite sprite;
    
	// Start is called before the first frame update
	void Start()
	{
		sprite = this.GetComponent<SpriteRenderer>().sprite;
	}
    
	// getter methods
	public float GetRarity() { return rarity; }
	public Sprite GetSprite() { return sprite; }
	
	// setter methods
	public void SetRarity(int newRarity) { rarity = newRarity; }
}