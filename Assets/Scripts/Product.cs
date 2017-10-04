using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Product : MonoBehaviour
{
    [SerializeField]
    VideoPlayer drillGameplay;
    [SerializeField]
    RawImage image;

	void Start ()
    {
        image.texture = drillGameplay.texture;
	}
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            drillGameplay.Play();
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            drillGameplay.Pause();
        }
	}
}
