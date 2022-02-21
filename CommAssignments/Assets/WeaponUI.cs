using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Weapon")]
public class WeaponUI : ScriptableObject
{
    public new string name;
    public string description;

    public Sprite artWork;

    public bool isGun;
    public int ammo;
    public int durability;
    public int dmgSec;
   

}
