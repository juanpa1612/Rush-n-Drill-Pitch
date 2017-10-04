using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team : MonoBehaviour
{
    [SerializeField]
    GameObject descriptions;

    Animator animDescriptions;
    int actualState;
	void Start ()
    {
        animDescriptions = descriptions.GetComponent<Animator>();
	}
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space) && actualState <3)
        {
            actualState++;
            animDescriptions.SetInteger("State", actualState);
        }
        if (Input.GetKeyDown(KeyCode.X) && actualState >0)
        {
            actualState--;
            animDescriptions.SetInteger("State", actualState);
        }
    }
}
