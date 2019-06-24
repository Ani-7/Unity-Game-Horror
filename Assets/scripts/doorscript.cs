using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorscript : MonoBehaviour
{
	public Animator anim;
	private bool t;
	public AudioClip open;
	public AudioClip close;
	public AudioSource doorsound;
    
	void Awake()
    {
		anim = GetComponent <Animator> ();
		doorsound= GetComponent<AudioSource>();
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
					if(anim.GetBool("butt"))
					{
						
						doorsound.PlayOneShot(open);
					anim.SetBool("butt",false);
					}
					else
					{	
						doorsound.PlayOneShot(close);
					anim.SetBool("butt",true);

					}
				}
			}			
			

		
	
	}
}

