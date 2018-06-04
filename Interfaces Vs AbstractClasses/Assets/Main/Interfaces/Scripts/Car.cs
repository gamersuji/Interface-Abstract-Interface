using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Interfaces
{
public class Car : MonoBehaviour,ITakeDamage //to inherit it you need to implement the interface, so select the Itake Damage written here and press ctrl + period aka (.) and you,ll be asked whether or not to implement the interface, click the first option to implement it 
{

	private	int health  = 10;

    public void TakeDamage(int damage)
    {
		health -= damage;

		if(health<=0)
		{
			Destroy(gameObject);
		}
    } 
}
}
