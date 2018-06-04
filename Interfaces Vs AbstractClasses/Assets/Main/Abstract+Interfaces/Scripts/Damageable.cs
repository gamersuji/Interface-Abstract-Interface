using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractAndInterface
{
public abstract class Damageable : MonoBehaviour ,ITakeDamage
{
	[SerializeField]private int maxHealth;
	private int health;

	private void Awake()
	{
		health = maxHealth;
	}

	public void TakeDamage(int damage) //overriding the Take Damage Method from the interface
	{
		health -= damage;

		if(health <= 0)
			Destroy(gameObject);
	}

	// void Update() //Update works here super fine
	// {
	// 	Debug.Log("I'm an abstract componetent and Update is working over here");
	// }

	public virtual void DebuggableData()
	{
		Debug.Log("The Original Data From The Abstract Class "+this.gameObject.name);
	}

}
}