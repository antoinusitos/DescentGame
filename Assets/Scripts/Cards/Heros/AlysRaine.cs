using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlysRaine : Hero 
{
    public override void InitHero()
    {
        base.InitHero();

        _name = "Alys Raine";

        _health = 12;
        _speed = 6;
        _stamina = 4;
        _defense = 1;

        _currentHealth = _health;
        _currentSpeed = _speed;
        _currentStamina = _stamina;
        _currentDefense = _defense;

        _might = 3;
        _knowledge = 4;
        _willpower = 3;
        _awareness = 1;

        _currentArchetype = Archetype.warrior;
        _currentAbility = Ability.ability1;
        _currentFeat = Feat.feat1;

        _currentState = State.alive;
    }
}
