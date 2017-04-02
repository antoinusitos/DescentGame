using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour 
{
    public enum DiceType
    {
        none,
        blue,
        red,
        yellow,
        green,
        brown,
        white,
        black,
    }

    public DiceType beginType = DiceType.none;
    public bool useBeginType = false;

    protected DiceType _diceType = DiceType.none;
    protected int _faces = 6;

    protected List<DiceFace> _allFaces;

    void Start()
    {
        _diceType = DiceType.none;
        _faces = 6;

        if(useBeginType)
        {
            Init(beginType);
        }
    }

    public void Init(DiceType newType)
    {
        _allFaces = new List<DiceFace>();
        switch(newType)
        {
            case DiceType.black:
                _allFaces.Add(new ZeroShield());
                _allFaces.Add(new TwoShield());
                _allFaces.Add(new TwoShield());
                _allFaces.Add(new TwoShield());
                _allFaces.Add(new ThreeShield());
                _allFaces.Add(new FourShield());
                break;

            case DiceType.white:
                _allFaces.Add(new ZeroShield());
                _allFaces.Add(new OneShield());
                _allFaces.Add(new OneShield());
                _allFaces.Add(new OneShield());
                _allFaces.Add(new TwoShield());
                _allFaces.Add(new ThreeShield());
                break;

            case DiceType.brown:
                _allFaces.Add(new ZeroShield());
                _allFaces.Add(new ZeroShield());
                _allFaces.Add(new ZeroShield());
                _allFaces.Add(new OneShield());
                _allFaces.Add(new OneShield());
                _allFaces.Add(new TwoShield());
                break;

            case DiceType.green:
                _allFaces.Add(new OneDamage());
                _allFaces.Add(new OneLight());
                _allFaces.Add(new OneLightOne());
                _allFaces.Add(new OneDamageOne());
                _allFaces.Add(new OneDamageOneLight());
                _allFaces.Add(new OneDamageOneLightOne());
                break;

            case DiceType.yellow:
                _allFaces.Add(new OneLightOne());
                _allFaces.Add(new OneDamageOne());
                _allFaces.Add(new OneDamageTwo());
                _allFaces.Add(new OneDamageOneLight());
                _allFaces.Add(new TwoDamage());
                _allFaces.Add(new TwoDamageOneLight());
                break;

            case DiceType.red:
                _allFaces.Add(new OneDamage());
                _allFaces.Add(new TwoDamage());
                _allFaces.Add(new TwoDamage());
                _allFaces.Add(new TwoDamage());
                _allFaces.Add(new ThreeDamage());
                _allFaces.Add(new ThreeDamageOneLight());
                break;

            case DiceType.blue:
                _allFaces.Add(new MissFace());
                _allFaces.Add(new TwoDamageOneLightTwo());
                _allFaces.Add(new TwoDamageThree());
                _allFaces.Add(new TwoDamageFour());
                _allFaces.Add(new OneDamageFive());
                _allFaces.Add(new OneDamageOneLightSix());
                break;
        }


        foreach (DiceFace df in _allFaces)
        {
            df.Init();
        }
    }

    public virtual void Play()
    {
        int rand = Random.Range(0, _faces);
        _allFaces[rand].ToString();
    }

    public void ToString()
    {
        foreach (DiceFace df in _allFaces)
        {
            Debug.Log("Debug of one face !");
            df.ToString();
        }
    }
}
