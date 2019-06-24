using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerrespawn : MonoBehaviour
{

	private void OnTriggerEnter(Collider other)
	{
		if(other.tag=="Respawn")	
		{
			Scene scene = SceneManager.GetActiveScene();
			SceneManager.LoadScene(scene.name);
		}
	}
}
