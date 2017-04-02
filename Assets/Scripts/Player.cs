using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{
    protected List<Card> _cards = null;

    protected Hero _currentHero = null;

    protected int _gold = 0;

    protected GameObject _currentPawn = null;

    protected bool _playerTurn = false;

    protected string _name = "UNKNONW";

    void Start()
    {
        _cards = new List<Card>();
        _currentHero = null;
        _gold = 0;
        _currentPawn = null;
        _playerTurn = false;
        _name = "UNKNONW";
    }

    public void InitPlayer(string newName)
    {
        _name = newName;
        _gold = 250;
    }

    public void DebugAllCards()
    {
        Debug.Log("Debug all cards");
        foreach (Card c in _cards)
        {
            Debug.Log("!!!!! NEW CARD !!!!!");
            Debug.Log(" ");
            c.ToString();
        }
        Debug.Log("end of current hand");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            InitPlayer("Antoine");
            Debug.Log("name:"+_name);
            Debug.Log("gold :"+_gold);
        }
    }

    public void AddCard(Card newCard)
    {
        _cards.Add(newCard);
    }
}
