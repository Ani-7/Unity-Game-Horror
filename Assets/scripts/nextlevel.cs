using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class nextlevel : MonoBehaviour {

	public string level;

	private void OnTriggerEnter()
	{
		SceneManager.LoadScene (level);
	}
}
