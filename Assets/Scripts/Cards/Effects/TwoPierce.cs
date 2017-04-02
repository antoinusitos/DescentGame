using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoPierce : Effect
{
    public override void Init() 
    {
        _cause = Cause.light;
        _reaction = Reaction.pierce;
        _reactionAmount = 2;
    }
}
