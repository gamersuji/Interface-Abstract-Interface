using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractAndInterface
{
public class DamageOnClick : MonoBehaviour 
{
	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		{

			#region  One Way Of Doing This

			// Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			// RaycastHit hit;

			// if(Physics.Raycast(ray,out hit))
			// {
			// 	ITakeDamage damageable = hit.collider.GetComponent<ITakeDamage>(); //one way of using the abstract method by interfacing it with an interface

			// 	if(damageable != null)
			// 	{
			// 		damageable.TakeDamage(1);
			// 	}
			// }

			#endregion
		
			var damageables = FindObjectsOfType<Damageable>(); //with Interface you cannot do the "FindObjectOfType" API you can ony do it by connecting them with abstracts

			foreach(var damageable in damageables)
			{
				damageable.TakeDamage(1);
				damageable.DebuggableData();
			}

		
		}
		
	}
}
}
