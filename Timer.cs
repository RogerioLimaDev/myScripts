using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

[SerializeField]
float timeToShoot;

[SerializeField]
GameObject projectile;

private void Update() 
{
	if(Input.GetButtonDown("Jump") && timeToShoot>0)
	{
		int random = Random.Range(5,10);
		Instantiate(projectile, transform.position, Quaternion.identity);
		projectile.GetComponent<Rigidbody>().velocity = new Vector3(random,10,random);
		ChangeColor();
	}



	timeToShoot = timeToShoot - Time.deltaTime;

	Debug.Log(timeToShoot.ToString());


}

void ChangeColor()
{
		Collider[] hitColliders = Physics.OverlapSphere( transform.position, 100);
        
        for(int i = 0 ; i < hitColliders.Length, i++)
        {
            hitColliders[i].GetComponent<Renderer>().material.color = Color.red;
        }
}

}
