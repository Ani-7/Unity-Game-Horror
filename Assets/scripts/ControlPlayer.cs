using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
   
    public void SetPlayer(bool allowMovement)
    {
        var fpc = FindObjectOfType<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>();
        if (fpc != null)
        {
            fpc.enabled = allowMovement;
        }
        else
        {
            Debug.LogWarning("Can't find a FirstPersonController in the current scene!");
        }
    }

}
