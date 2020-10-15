using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Dropdown))]
public class DropDown : MonoBehaviour
{
    [SerializeField] private CharacterAnimation _characterAnimation;
    private Dropdown _listAnimations;
    private int _idAnimation;
    List<string> _list = new List<string> { 
    "Lift",
    "PushLever",
    "Fall",
    "FallingHold",
    "FallingContinueHolding",
    "FallDeath",
    "FallFireDeath",
    "Run",
    "RunningHold",
    "UseItem",
    "Dancing",
    "OpenChest",
    "Level_1Fire",
    "Level_1Death",
    "Level_1TakeMatch_Anim",
    "Level_1TakeScrowbar_Anim",
    "Level_2_Sword_Anim",
    "Level_2_Mirror_Anim",
    "Level_2_Death_Anim",
    "Level3_TakeKey",
    "Level3TakeDinamite",
    "Level3HeroOpenChest",
    "Level_4_Sparow_Anim",
    "Level_4_Cat_Anim",
    "Level_5_Burger_Anim",
    "Level_5_Wearing_Anim",
    "Level_5_Drakula_Anim",
    "Level6Hoover",
    "Level6TakePick",
    "Level_7_Flash_Anim",
    "Level_7_Box_Anim",
    "Level_8_Stilts_Anim",
    "Level_9_Fruits_Anim",
    "Level_9_Phone_Anim",
    "Level_10_Pipe_Anim",
    "Level_10_Box_Anim"
    };

    private void Awake()
    {        
        _listAnimations = GetComponent<Dropdown>();
        _listAnimations.AddOptions(_list);
    }

    public void ChangedLevel()
    {        
        _characterAnimation.SetAnimation(_list[_listAnimations.value]);
    }
}
