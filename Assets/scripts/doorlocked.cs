using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorlocked : MonoBehaviour
{
        public AudioSource locksound;
		private bool t;
    
	void Awake()
    {
		locksound= GetComponent<AudioSource>();
    }

	void OnTriggerEnter(Collider other)
		{
			if(other.tag=="Player")	
			{
				t=true;
			}
			
        }

	void OnTriggerExit(Collider other)
		{
			if(other.tag=="Player")	
			{
				t=false;
			}
			
        }

	
	void Update()
	{
		if(t)
		{
		
				if(Input.GetKeyDown("e"))
				{
                	locksound.Play();
            	}

		}
			
    }
}
