using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect //: MonoBehaviour 
{
    public enum Cause
    {
        none,
        light,
    }

    public enum Reaction
    {
        none,
        range,
        pierce,
        damage,
        immobilize,
        stun,
    }

    protected Cause _cause;
    protected Reaction _reaction;

    protected int _reactionAmount;

    void Start()
    {
        _cause = Cause.none;
        _reaction = Reaction.none;

        _reactionAmount = 0;
    }

    public void ToString()
    {
        Debug.Log("_cause : " + _cause);
        Debug.Log("_reaction : " + _reaction);
        Debug.Log("_reactionAmount : " + _reactionAmount);
    }

    public virtual void Init()
    {

    }
}
