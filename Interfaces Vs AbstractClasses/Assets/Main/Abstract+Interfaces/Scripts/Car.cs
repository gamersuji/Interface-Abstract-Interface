using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractAndInterface
{
public class Car : Damageable
{

    public void TakeDamage(int damage) //cannot override These
    {
        damage = 0;
        Debug.Log("Cannot be overriden");
    }

    public override void DebuggableData() // can override this since it is a virtual function
    {
        Debug.Log("Overridden Debug Of The Class "+this.gameObject.name);
    }

}
}
