using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponDisplay : MonoBehaviour
{
    public WeaponUI weapon;

    public Image artWork;

    public Text nameText;
    public Text type;
    public Text ammDur;
    public Text description;
    public Text ammo;
    public Text dur;
    public Text dmg;


    void Start()
    {
        nameText.text = weapon.name;
        artWork.sprite = weapon.artWork;
        dmg.text = weapon.dmgSec.ToString();
        description.text = weapon.description;

        if (weapon.isGun)
        {
            type.text = "Gun";
            ammDur.text = "Ammo: ";
            ammo.text = weapon.ammo.ToString();

        }
        else
        {
            type.text = "Melee";
            ammDur.text = "Durability: ";
            ammo.text = weapon.durability.ToString();
        }


    }

    
}
