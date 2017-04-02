using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcaneBolt : Item 
{
    void Start()
    {
        _name = "Arcane Bolt";
        _cardType = CardType.item;

        _dicesNeeded = new List<Dice.DiceType>();
        _dicesNeeded.Add(Dice.DiceType.blue);
        _dicesNeeded.Add(Dice.DiceType.yellow);

        _currentArchetype = Archetype.crossbow;
        _currentWearingType = WearingType.twoHanded;

        _buyingCost = 25;
        _sellingCost = 25;

        _effects = new List<Effect>();
        TwoPierce tp = new TwoPierce();
        tp.Init();
        _effects.Add(tp);
        OneRange or = new OneRange();
        or.Init();
        _effects.Add(or);

    }
}
