using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : Card
{
    public enum Archetype
    {
        none,
        crossbow,
        sword,
        shield,
        armor,
    }

    public enum WearingType
    {
        none,
        oneHanded,
        twoHanded,
    }

    // The dices needed to play this item
    protected List<Dice.DiceType> _dicesNeeded;

    // The base stats of this weapon
    protected Archetype _currentArchetype;
    protected WearingType _currentWearingType;

    // When trading it
    protected int _buyingCost;
    protected int _sellingCost;

    // All the effects of this item
    protected List<Effect> _effects;

    void Start()
    {
        _cardType = CardType.hero;
        _owner = null;
        _name = "UNKNOWN";

        _dicesNeeded = new List<Dice.DiceType>();

        _currentArchetype = Archetype.none;
        _currentWearingType = WearingType.none;

        _buyingCost = 0;
        _sellingCost = 0;

        _effects = new List<Effect>();
    }

    public override void ToString()
    {
        base.ToString();
        foreach (Dice.DiceType dt in _dicesNeeded)
        {
            Debug.Log("_dicesNeeded : " + dt);
        }
        Debug.Log("_currentArchetype : " + _currentArchetype);
        Debug.Log("_currentWearingType : " + _currentWearingType);
        Debug.Log("_buyingCost : " + _buyingCost);
        Debug.Log("_sellingCost : " + _sellingCost);

        foreach(Effect e in _effects)
        {
            e.ToString();
        }
    }
}
