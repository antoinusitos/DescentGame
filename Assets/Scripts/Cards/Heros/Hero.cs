using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : Card
{
    public enum Archetype
    {
        none,
        warrior,
        healer,
        scout,
        mage,
    }

    public enum Ability
    {
        none,
        ability1,
        ability2,
        ability3,
        ability4,
    }

    public enum Feat
    {
        none,
        feat1,
        feat2,
        feat3,
        feat4,
    }

    public enum State
    {
        none,
        alive,
        dead,
        stun,
    }

    // base stat
    protected int _health = -1;
    protected int _speed = -1;
    protected int _stamina = -1;
    protected int _defense = -1;

    // changing stat
    protected int _currentHealth = -1;
    protected int _currentSpeed = -1;
    protected int _currentStamina = -1;
    protected int _currentDefense = -1;

    // deep stats
    protected int _might = -1;
    protected int _knowledge = -1;
    protected int _willpower = -1;
    protected int _awareness = -1;

    // hero personalization
    protected Archetype _currentArchetype = Archetype.none;
    protected Ability _currentAbility = Ability.none;
    protected Feat _currentFeat = Feat.none;

    protected State _currentState = State.none;

    // action every turn (2 normally)
    protected int _actionRemaining = -1;
    protected const int actionPerTurn = 2;

    // currentlyEquipped
    protected bool leftGlove = false;
    protected bool rightGlove = false;
    protected bool armor = false;

	void Start () 
    {
        _cardType = CardType.hero;
        _owner = null;
        _name = "UNKNOWN";

        _health = 6;
        _currentHealth = _health;
        _speed = 4;
        _currentSpeed = _speed;
        _stamina = 4;
        _currentStamina = _stamina;
        _defense = 2;
        _currentDefense = _defense;

        _might = 1;
        _knowledge = 1;
        _willpower = 1;
        _awareness = 1;

        _currentArchetype = Archetype.none;
        _currentAbility = Ability.none;
        _currentFeat = Feat.none;

        _currentState = State.none;

        _actionRemaining = actionPerTurn;

        leftGlove = false;
        rightGlove = false;
        armor = false;
	}

    public void TakeDamage(int amount)
    {
        _health -= amount;
        if(_health <= 0)
        {
            _health = 0;
            _currentState = State.dead;
        }
    }

    public void WakeUp()
    {
        if (_currentState == State.stun)
        {
            _currentState = State.alive;
        }
    }

    public void ConsumeAction()
    {
        _actionRemaining -= 1;
    }

    public void Move(Vector3 pos)
    {
        transform.position = pos;

        // @Upgrade : remove the speed amount
    }
}
