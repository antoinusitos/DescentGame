using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour 
{
    //
    // Singleton
    //

    private static GameManager _instance;

    public static GameManager GetInstance()
    {
        return _instance;
    }

    void Awake()
    {
        _instance = this;
    }

    //
    // End Singleton
    //

    public GameObject playerPrefab;

    private List<Player> _allPlayers;
    private Player _playerTurn;

    //
    // DEBUG
    // 

    public GameObject debugCard;
    public GameObject debugDice;

    private Dice _blueDice = null;

    //
    // END DEBUG
    //

    void Start()
    {
        _allPlayers = new List<Player>();
    }

    public void EndPlayerTurn()
    {
        _playerTurn.EndPlayerTurn();
        foreach (Player p in _allPlayers)
        {
            if (p.GetHero().CheckHaveActions())
            {
                return;
            }
        }

        StartCoroutine(EndGameTurn());
    }

    IEnumerator EndGameTurn()
    {
        // do something at the end of the turn
        yield return new WaitForSeconds(1.0f);
        BeginGameTurn();
    }

    public void BeginGameTurn()
    {
        foreach (Player p in _allPlayers)
        {
            p.BeginGameTurn();
        }
    }

    public void DebugTakeTurn()
    {
        _allPlayers[0].BeginPlayerTurn();
        _playerTurn = _allPlayers[0];
    }

    IEnumerator DebugCreatePlayer()
    {
        _allPlayers.Add(Instantiate(playerPrefab).GetComponent<Player>());
        yield return new WaitForEndOfFrame();
        _allPlayers[0].InitPlayer("Antoine");
        GameObject go = Instantiate(debugCard);
        go.GetComponent<Hero>().InitHero();
        go.GetComponent<Hero>().SetOwner(_allPlayers[0]);
        _allPlayers[0].AddCard(go.GetComponent<Card>());
        _allPlayers[0].SetHeroCard(go.GetComponent<Hero>());
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            StartCoroutine(DebugCreatePlayer());
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            _allPlayers[0].DebugAllCards();
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            Debug.Log("blue dice");
            DiceManager.GetInstance().Play(Dice.DiceType.blue);
            Debug.Log("red dice");
            DiceManager.GetInstance().Play(Dice.DiceType.red);
            Debug.Log("red dice");
            DiceManager.GetInstance().Play(Dice.DiceType.red);
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log("red dice");
            DiceManager.GetInstance().Play(Dice.DiceType.red);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            _allPlayers[0].SetSquarePos(BoardManager.GetInstance().GetFirstSquare());
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            _allPlayers[0].BeginGameTurn();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            _playerTurn = _allPlayers[0];
            _allPlayers[0].BeginPlayerTurn();
        }
    }

}
