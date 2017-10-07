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
    [SerializeField]
    MovieTexture movie;

	void Start ()
    {
        image.texture = movie as MovieTexture;
	}
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            movie.Play();
            
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            drillGameplay.Pause();
        }
	}
}
