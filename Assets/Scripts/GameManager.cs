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

    private List<GameObject> _allPlayers;
    private GameObject _playerTurn;

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
        _allPlayers = new List<GameObject>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            _allPlayers.Add(Instantiate(playerPrefab));
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            GameObject go = Instantiate(debugCard);
            go.GetComponent<Card>().SetOwner(_allPlayers[0].GetComponent<Player>());
            _allPlayers[0].GetComponent<Player>().AddCard(go.GetComponent<Card>());
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            _allPlayers[0].GetComponent<Player>().DebugAllCards();
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
            _allPlayers[0].GetComponent<Player>().SetSquarePos(BoardManager.GetInstance().GetFirstSquare());
        }
    }

}
