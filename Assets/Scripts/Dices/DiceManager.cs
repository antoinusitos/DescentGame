using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceManager : MonoBehaviour 
{

    //
    // Singleton
    //

    private static DiceManager _instance;

    public static DiceManager GetInstance()
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

    public GameObject blueDicePrefab;
    public GameObject yellowDicePrefab;
    public GameObject greenDicePrefab;
    public GameObject redDicePrefab;
    public GameObject brownDicePrefab;
    public GameObject whiteDicePrefab;
    public GameObject blackDicePrefab;

    private GameObject _blueDice;
    private GameObject _yellowDice;
    private GameObject _greenDice;
    private GameObject _redDice;
    private GameObject _brownDice;
    private GameObject _whiteDice;
    private GameObject _blackDice;

    void Start()
    {
        _blueDice = Instantiate(blueDicePrefab);
        _yellowDice = Instantiate(yellowDicePrefab);
        _greenDice = Instantiate(greenDicePrefab);
        _redDice = Instantiate(redDicePrefab);
        _brownDice = Instantiate(brownDicePrefab);
        _whiteDice = Instantiate(whiteDicePrefab);
        _blackDice = Instantiate(blackDicePrefab);
    }

    public void Play(Dice.DiceType typeToPlay)
    {
        switch(typeToPlay)
        {
            case Dice.DiceType.blue:
                _blueDice.GetComponent<Dice>().Play();
                break;
            case Dice.DiceType.black:
                _blackDice.GetComponent<Dice>().Play();
                break;
            case Dice.DiceType.brown:
                _brownDice.GetComponent<Dice>().Play();
                break;
            case Dice.DiceType.green:
                _greenDice.GetComponent<Dice>().Play();
                break;
            case Dice.DiceType.red:
                _redDice.GetComponent<Dice>().Play();
                break;
            case Dice.DiceType.white:
                _whiteDice.GetComponent<Dice>().Play();
                break;
            case Dice.DiceType.yellow:
                _yellowDice.GetComponent<Dice>().Play();
                break;
        }
    }
}
