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

    protected Square _currentSquare;

    protected int _numberAction = 2;

    public Material selected;
    public Material unselected;

    public GameObject playerInfoPrefab;
    protected InfoCard _infoCard;

    void Start()
    {
        //_currentHero = null;
        _gold = 0;
        _currentPawn = null;
        _playerTurn = false;
        _name = "UNKNONW";
    }

    public void InitPlayer(string newName)
    {
        _cards = new List<Card>();
        _name = newName;
        _gold = 250;
        Debug.Log("name:" + _name);
        Debug.Log("gold :" + _gold);
    }

    public void SetHeroCard(Hero newHero)
    {
        _currentHero = newHero;
        GameObject go = Instantiate(playerInfoPrefab);
        _infoCard = go.GetComponent<InfoCard>();

        _infoCard.heroName.text = _currentHero.GetName();

        _infoCard.heroHealth.text = "Health : " + _currentHero.GetHealth().ToString();
        _infoCard.heroSpeed.text = "Speed : " + _currentHero.GetSpeed().ToString();
        _infoCard.heroStamina.text = "Stamina : " + _currentHero.GetStamina().ToString();
        _infoCard.heroDefense.text = "Defense : " + _currentHero.GetDefense().ToString();

        _infoCard.heroMight.text = "Might : " + _currentHero.GetMight().ToString();
        _infoCard.heroWillpower.text = "Willpower : " + _currentHero.GetWillpower().ToString();
        _infoCard.heroKnowledge.text = "Knowledge : " + _currentHero.GetKnowledge().ToString();
        _infoCard.heroAwareness.text = "Awareness : " + _currentHero.GetAwareness().ToString();
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

    public void AddCard(Card newCard)
    {
        _cards.Add(newCard);
    }

    public void SetSquarePos(Square newPos)
    {
        _currentSquare = newPos;
        transform.position = _currentSquare.transform.position;

        // @Upgrade : add the speed amount
    }

    public void BeginGameTurn()
    {
        Debug.Log("Begin game turn on : " + name);
        _playerTurn = false;
        _currentHero.ResetHero();
    }

    public void BeginPlayerTurn()
    {
        Debug.Log("Begin player turn : " + name);
        _playerTurn = true;
        SetSelected(true);
    }

    public void EndPlayerTurn()
    {
        _playerTurn = false;
        SetSelected(false);
    }

    public Hero GetHero()
    {
        return _currentHero;
    }

    public void SetSelected(bool newSelection)
    {
        if(newSelection)
        {
            transform.GetChild(0).GetComponent<MeshRenderer>().material = selected;
        }
        else
        {
            transform.GetChild(0).GetComponent<MeshRenderer>().material = unselected;
        }
    }
}
