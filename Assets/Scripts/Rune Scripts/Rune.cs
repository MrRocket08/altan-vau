using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName = "Rune", menuName = "ScriptableObjects/Rune", order = 1)]
public class Rune : ScriptableObject
{
    public int runeLevel = 1;
    public string runeName;
    public int manaCost;

    public enum RuneType { Action, Conditional, Parameter, Imbuement }
    public RuneType type = 0;
    
    protected Rune NextRune;
    protected Rune PrevRune;

    protected GameObject MagicObject;
    
    // constructor
    /* public Rune(int runeLevel, string runeName)
    {
        this.runeLevel = runeLevel;
        this.runeName = runeName;
    } */
    
    // class methods
    public virtual void RuneFunction()
    {
        // calls the next rune in the spell
        if (NextRune != null)
            NextRune.RuneFunction();
        else return;
    }
    
    public virtual void RuneFunction(GameObject magicObject)
    {
        // rune does its thing
        
        // calls the next rune in the spell
        if (NextRune != null)
            NextRune.RuneFunction(magicObject);
        else return;
    }
    
    // getter methods
    public int GetLevel () { return runeLevel; }
    public int GetManaCost() { return manaCost; }
    public Rune GetNextRune () { return NextRune; }
    public Rune GetPrevRune () { return PrevRune; }
    
    // setter methods
    public void SetNextRune (Rune rune) { NextRune = rune; }
    public void SetPrevRune (Rune rune) { PrevRune = rune; }
}
