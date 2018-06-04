using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace  Interfaces
{
public class Barrel : MonoBehaviour,ITakeDamage 
{
    public void TakeDamage(int damage)
    {
		  Destroy(gameObject);
    }
}
}
