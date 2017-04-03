using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{

    //
    // Singleton
    //

    private static BoardManager _instance;

    public static BoardManager GetInstance()
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

    public Square GetFirstSquare()
    {
        return transform.GetChild(0).GetComponent<Square>();
    }
}
