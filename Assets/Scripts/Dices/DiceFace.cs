using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceFace 
{
    public enum FaceType
    {
        none,
        number,
        damage,
        light,
        miss,
        shield,
    }

    public struct aType
    {
        public FaceType theType;
        public int count;

        public aType(FaceType newType, int newCount)
        {
            theType = newType;
            count = newCount;
        }
    }

    public List<aType> _allTypes;
    

    public virtual void Init(){}

    public void ToString()
    {
        foreach(aType t in _allTypes)
        {
            Debug.Log("FaceType : " + t.theType);
            Debug.Log("count : " + t.count);
        }
    }

}

public class ZeroShield : DiceFace
{
    public override void Init()
    {
        _allTypes = new List<aType>();
        _allTypes.Add(new aType(FaceType.shield, 0));
    }
}

public class OneShield : DiceFace
{
    public override void Init()
    {
        _allTypes = new List<aType>();
        _allTypes.Add(new aType(FaceType.shield, 1));
    }
}

public class TwoShield : DiceFace
{
    public override void Init()
    {
        _allTypes = new List<aType>();
        _allTypes.Add(new aType(FaceType.shield, 2));
    }
}

public class ThreeShield : DiceFace
{
    public override void Init()
    {
        _allTypes = new List<aType>();
        _allTypes.Add(new aType(FaceType.shield, 3));
    }
}

public class FourShield : DiceFace
{
    public override void Init()
    {
        _allTypes = new List<aType>();
        _allTypes.Add(new aType(FaceType.shield, 4));
    }
}

public class OneDamage : DiceFace
{
    public override void Init()
    {
        _allTypes = new List<aType>();
        _allTypes.Add(new aType(FaceType.damage, 1));
    }
}

public class OneLight : DiceFace
{
    public override void Init()
    {
        _allTypes = new List<aType>();
        _allTypes.Add(new aType(FaceType.light, 1));
    }
}

public class OneLightOne : DiceFace
{
    public override void Init()
    {
        _allTypes = new List<aType>();
        _allTypes.Add(new aType(FaceType.light, 1));
        _allTypes.Add(new aType(FaceType.number, 1));
    }
}

public class OneDamageOne : DiceFace
{
    public override void Init()
    {
        _allTypes = new List<aType>();
        _allTypes.Add(new aType(FaceType.damage, 1));
        _allTypes.Add(new aType(FaceType.number, 1));
    }
}

public class OneDamageOneLight : DiceFace
{
    public override void Init()
    {
        _allTypes = new List<aType>();
        _allTypes.Add(new aType(FaceType.damage, 1));
        _allTypes.Add(new aType(FaceType.light, 1));
    }
}

public class OneDamageOneLightOne : DiceFace
{
    public override void Init()
    {
        _allTypes = new List<aType>();
        _allTypes.Add(new aType(FaceType.damage, 1));
        _allTypes.Add(new aType(FaceType.light, 1));
        _allTypes.Add(new aType(FaceType.number, 1));
    }
}

public class OneDamageTwo : DiceFace
{
    public override void Init()
    {
        _allTypes = new List<aType>();
        _allTypes.Add(new aType(FaceType.damage, 1));
        _allTypes.Add(new aType(FaceType.number, 2));
    }
}

public class TwoDamage : DiceFace
{
    public override void Init()
    {
        _allTypes = new List<aType>();
        _allTypes.Add(new aType(FaceType.damage, 2));
    }
}

public class TwoDamageOneLight : DiceFace
{
    public override void Init()
    {
        _allTypes = new List<aType>();
        _allTypes.Add(new aType(FaceType.damage, 2));
        _allTypes.Add(new aType(FaceType.light, 1));
    }
}

public class ThreeDamage : DiceFace
{
    public override void Init()
    {
        _allTypes = new List<aType>();
        _allTypes.Add(new aType(FaceType.damage, 3));
    }
}

public class ThreeDamageOneLight : DiceFace
{
    public override void Init()
    {
        _allTypes = new List<aType>();
        _allTypes.Add(new aType(FaceType.damage, 3));
        _allTypes.Add(new aType(FaceType.light, 1));
    }
}

public class MissFace : DiceFace
{
    public override void Init()
    {
        _allTypes = new List<aType>();
        _allTypes.Add(new aType(FaceType.miss, 1));
    }
}

public class TwoDamageOneLightTwo : DiceFace
{
    public override void Init()
    {
        _allTypes = new List<aType>();
        _allTypes.Add(new aType(FaceType.damage, 2));
        _allTypes.Add(new aType(FaceType.light, 1));
        _allTypes.Add(new aType(FaceType.number, 2));
    }
}

public class TwoDamageThree : DiceFace
{
    public override void Init()
    {
        _allTypes = new List<aType>();
        _allTypes.Add(new aType(FaceType.damage, 2));
        _allTypes.Add(new aType(FaceType.number, 3));
    }
}

public class TwoDamageFour : DiceFace
{
    public override void Init()
    {
        _allTypes = new List<aType>();
        _allTypes.Add(new aType(FaceType.damage, 2));
        _allTypes.Add(new aType(FaceType.number, 4));
    }
}

public class OneDamageFive : DiceFace
{
    public override void Init()
    {
        _allTypes = new List<aType>();
        _allTypes.Add(new aType(FaceType.damage, 1));
        _allTypes.Add(new aType(FaceType.number, 5));
    }
}

public class OneDamageOneLightSix : DiceFace
{
    public override void Init()
    {
        _allTypes = new List<aType>();
        _allTypes.Add(new aType(FaceType.damage, 1));
        _allTypes.Add(new aType(FaceType.light, 1));
        _allTypes.Add(new aType(FaceType.number, 6));
    }
}