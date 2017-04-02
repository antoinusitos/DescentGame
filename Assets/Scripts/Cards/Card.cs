using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour 
{
    public enum CardType
    {
        none,
        item,
        hero,
        skill,
        monster,
    }

    protected CardType _cardType = CardType.none;

    protected Player _owner = null;

    protected string _name = "UNKNOWN";

    public virtual void ToString()
    {
        Debug.Log("_name : " + _name);
        Debug.Log("_owner : " + _owner);
        Debug.Log("_cardType : " + _cardType);
    }

    public void SetOwner(Player newOwner)
    {
        _owner = newOwner;
    }
}
