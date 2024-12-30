using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Cast", menuName = "ScriptableObjects/Cast", order = 1)]
public class Cast : Rune
{
    public enum CastProjectile { Dart, Shot, Beam, Burst, Orb }
    public CastProjectile castProjectile;
    
    # region projectiles

    public static GameObject Dart;
    public static GameObject Shot;
    public static GameObject Beam;
    public static GameObject Burst;
    public static GameObject Orb;
    #endregion
    
    // event methods
    void OnEnable()
    {
        type = RuneType.Action;
    }

    // class methods
    new void RuneFunction()
    {
        switch (castProjectile)
        {
            case CastProjectile.Dart:
                MagicObject = GameObject.Instantiate(Dart);
                break;
            case CastProjectile.Shot:
                MagicObject = GameObject.Instantiate(Shot);
                break;
            case CastProjectile.Beam:
                MagicObject = GameObject.Instantiate(Beam);
                break;
            case CastProjectile.Burst:
                MagicObject = GameObject.Instantiate(Burst);
                break;
            case CastProjectile.Orb:
                MagicObject = GameObject.Instantiate(Orb);
                break;
        }

        NextRune.RuneFunction(MagicObject);
    }
}
