using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnButton : MonoBehaviour 
{

    public void TakeTurn()
    {
        GameManager.GetInstance().DebugTakeTurn();
    }

    public void EndTurn()
    {
        GameManager.GetInstance().EndPlayerTurn();
    }

}
