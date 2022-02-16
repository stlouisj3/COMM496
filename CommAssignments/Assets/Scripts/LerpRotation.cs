using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpRotation : MonoBehaviour
{
	Quaternion targetRotation;

	public Transform target;             
	public float speed = 0.1F;
	public bool Test = false;
	bool rotating = false;              

	float rotationTime; // when rotationTime == 1, will have rotated to our target

	void Update()
	{
        if (Test)
        {
			if (Input.GetKeyDown(KeyCode.Space))
		{
			Vector3 relativePosition = target.position - transform.position;
			targetRotation = Quaternion.LookRotation(relativePosition);
			rotating = true;
			rotationTime = 0;
			}


			if (rotating)
			{
			rotationTime += Time.deltaTime * speed;
			transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationTime);
			if (rotationTime > 1)
			{
				rotating = false;
			}
			}
		}
        if (!Test)
        {
			Vector3 relativePosition = target.position - transform.position;
			targetRotation = Quaternion.LookRotation(relativePosition);
			rotationTime += Time.deltaTime * speed;
			transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationTime);

        }
		
	}
	}
