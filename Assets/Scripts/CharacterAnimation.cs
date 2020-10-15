using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    private Animator _animatior;

    private void Awake()
    {
        _animatior = GetComponent<Animator>();
    }

    public void SetAnimation(String trigger)
    {
        Debug.Log(trigger);
        _animatior.SetTrigger(trigger);
    }
}

enum AnimationMove
{
    Lift,
    PushLever,
    Fall,
    FallingHold,
    FallingContinueHolding,
    FallDeath,
    FallFireDeath,
    Run,
    RunningHold,
    UseItem,
    Dancing,
    OpenChest,
    Level_1Fire,
    Level_1Death,
    Level_1TakeMatch_Anim,
    Level_1TakeScrowbar_Anim,
    Level_2_Sword_Anim,
    Level_2_Mirror_Anim,
    Level_2_Death_Anim,
    Level3_TakeKey,
    Level3TakeDinamite,
    Level3HeroOpenChest,
    Level_4_Sparow_Anim,
    Level_4_Cat_Anim,
    Level_5_Burger_Anim,
    Level_5_Wearing_Anim,
    Level_5_Drakula_Anim,
    Level6Hoover,
    Level6TakePick,
    Level_7_Flash_Anim,
    Level_7_Box_Anim,
    Level_8_Stilts_Anim,
    Level_9_Fruits_Anim,
    Level_9_Phone_Anim,
    Level_10_Pipe_Anim,
    Level_10_Box_Anim 
}
