using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Rune", menuName = "ScriptableObjects/Rune", order = 1)]
public class Rune : ScriptableObject
{
    public int runeLevel = 1;
    public string runeName;
    public int manaCost;

    public enum RuneType { Action, Conditional, Parameter, Imbuement }
    public RuneType type = 0;
    
    private Rune nextRune;
    private Rune prevRune;

    // constructor
    public Rune(int runeLevel, string runeName)
    {
        this.runeLevel = runeLevel;
        this.runeName = runeName;
    }
    
    // class methods
    public void RuneFunction()
    {
        // rune does its thing
        
        // calls the next rune in the spell
        prevRune.RuneFunction();
    }
    
    // getter methods
    public int GetLevel () { return runeLevel; }
    public int GetManaCost() { return manaCost; }
    public Rune GetNextRune () { return nextRune; }
    public Rune GetPrevRune () { return prevRune; }
    
    // setter methods
    public void SetNextRune (Rune rune) { nextRune = rune; }
    public void SetPrevRune (Rune rune) { prevRune = rune; }
}
