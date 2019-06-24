using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class doorentry : MonoBehaviour
{
	public PlayableDirector pd;

	private void OnTriggerEnter(Collider other)
	{
		if(other.tag=="Player")	
		{
			pd.Play();
		}

	}
}
