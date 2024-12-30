using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;

[CreateAssetMenu(fileName = "Cast", menuName = "ScriptableObjects/Cast", order = 1)]
public class Cast : Rune
{
    private GameObject player;
    public enum CastProjectile { Dart, Shot, Beam, Burst, Orb }
    public CastProjectile castProjectile;
    
    # region projectiles
        public GameObject Dart;
        //public static GameObject Shot; will use raycasting
        //public static GameObject Beam; will use raycasting
        //public static GameObject Burst; will use conecasting
        public GameObject Orb;
    #endregion
    
    // event methods
    void OnEnable()
    {
        Dart = Resources.Load("Dart") as GameObject;
        Orb = Resources.Load("Orb") as GameObject;
        
        type = RuneType.Action;
        
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // class methods
    public override void RuneFunction()
    {
        switch (castProjectile)
        {
            case CastProjectile.Dart:
                MagicObject = GameObject.Instantiate(Dart, player.transform.position, Quaternion.identity);
                break;
            /* case CastProjectile.Shot:
                MagicObject = GameObject.Instantiate(Shot);
                break;
            case CastProjectile.Beam:
                MagicObject = GameObject.Instantiate(Beam);
                break;
            case CastProjectile.Burst:
                MagicObject = GameObject.Instantiate(Burst);
                break; */
            case CastProjectile.Orb:
                MagicObject = GameObject.Instantiate(Orb, player.transform.position, Quaternion.identity);
                break;
        }

        if (NextRune != null)
            NextRune.RuneFunction(MagicObject);
    }
}
