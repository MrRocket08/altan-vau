using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Item : ScriptableObject
{
	private float rarity = 0f;
	private Sprite sprite;
    
	// Start is called before the first frame update
	void Start()
	{
		sprite = this.GetComponent<SpriteRenderer>().sprite;
	}
    
	public float GetRarity() { return rarity; }
	public void SetRarity(float newRarity) { rarity = newRarity; }

	public Sprite GetSprite() { return sprite; }
}