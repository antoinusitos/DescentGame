using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneRange : Effect
{
    public override void Init() 
    {
        _cause = Cause.light;
        _reaction = Reaction.range;
        _reactionAmount = 1;
	}
	
}
