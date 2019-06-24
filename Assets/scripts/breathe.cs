using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class breathe : MonoBehaviour {

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