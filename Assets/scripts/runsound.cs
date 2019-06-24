using UnityEngine;
using System.Collections;

public class runsound : MonoBehaviour {

	public AudioSource aud;

	void Start ()
	{
		aud = GetComponent<AudioSource>();
	}

	private void OnTriggerEnter()
	{
		aud.Play();
	}

	public void OnTriggerExit()
	{
		aud.enabled = false;
		aud.enabled = true;
	}

}
