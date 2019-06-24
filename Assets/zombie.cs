using UnityEngine;
using System.Collections;

public class zombie : MonoBehaviour {


	public Animator anim;
	public AudioSource aud;
	public AudioClip first;
	public AudioClip sec;


	void Awake(){

		aud = GetComponent<AudioSource> ();
		anim = GetComponent <Animator> ();

	}

	private void OnTriggerEnter()
	{
		
		anim.ResetTrigger ("exit");
		anim.SetTrigger ("enter");
		aud.Stop ();
		aud.loop = true;
		aud.clip = sec;
		aud.Play();
	}

	private void OnTriggerExit()
	{
		
		anim.ResetTrigger ("enter");
		anim.SetTrigger ("exit");
		aud.Stop ();
		aud.loop = true;
		aud.clip = first;
		aud.Play();
	}

}
