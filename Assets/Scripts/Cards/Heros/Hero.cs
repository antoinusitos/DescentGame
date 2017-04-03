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
        
	}

    public virtual void InitHero()
    {
        _cardType = CardType.hero;
        _owner = null;
        _name = "UNKNOWN";

        _health = -1;
        _currentHealth = _health;
        _speed = -1;
        _currentSpeed = _speed;
        _stamina = -1;
        _currentStamina = _stamina;
        _defense = -1;
        _currentDefense = _defense;

        _might = -1;
        _knowledge = -1;
        _willpower = -1;
        _awareness = -1;

        _currentArchetype = Archetype.none;
        _currentAbility = Ability.none;
        _currentFeat = Feat.none;

        _currentState = State.none;

        _actionRemaining = actionPerTurn;

        leftGlove = false;
        rightGlove = false;
        armor = false;
    }

    public void ResetHero()
    {
        _actionRemaining = actionPerTurn;
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

    public bool CheckHaveActions()
    {
        if (_actionRemaining <= 0)
            return false;
        return true;
    }

    public string GetName(){ return _name;}

    public int GetHealth() { return _currentHealth; }
    public int GetSpeed() { return _currentSpeed; }
    public int GetStamina() { return _currentStamina; }
    public int GetDefense() { return _currentDefense; }

    public int GetMight() { return _might; }
    public int GetKnowledge() { return _knowledge; }
    public int GetWillpower() { return _willpower; }
    public int GetAwareness() { return _awareness; }
}
