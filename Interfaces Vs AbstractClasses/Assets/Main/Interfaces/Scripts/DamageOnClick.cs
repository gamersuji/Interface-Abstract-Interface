using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Interfaces
{
public class DamageOnClick : MonoBehaviour {

	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if(Physics.Raycast(ray,out hit))
			{
				ITakeDamage damageable = hit.collider.GetComponent<ITakeDamage>();

				if(damageable != null)
				{
					damageable.TakeDamage(1); 
				}
			}
		}	
	}
}
}
