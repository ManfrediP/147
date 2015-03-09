using UnityEngine;
using System.Collections;

public class SphereMovement : MonoBehaviour 
{
	public Transform follower;
	public Transform myTransform;
	public float maxDistance;
	public float speed;
	bool entering = false;

	void Awake () 
	{
		myTransform = transform;
	}
	
	void Update () 
	{
		if (entering == true)
		{
			if (Vector3.Distance (follower.position, myTransform.position)> maxDistance)
			{
				transform.LookAt (follower.position);
				myTransform.position += myTransform.forward * speed * Time.deltaTime;
			}
		}
	}
	void OnTriggerEnter (Collider colli)
	{
		if (colli.gameObject.tag == ("Player"))
		{
			entering = true;
		}
	} 
}


