using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class animationScript : MonoBehaviour
{
    [SerializeField]
    GameObject[] pages;

    Animator[] animators;
    int actualPage  =   0;

    private void Start()
    {
        animators = new Animator[6];

        for (int i = 0; i < pages.Length; i++)
        {
            animators[i] = pages[i].GetComponent<Animator>();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && actualPage < pages.Length-1)
        {
            animators[actualPage].SetBool("Active", false);
            actualPage++;
            animators[actualPage].SetBool("Active", true);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && actualPage > 0)
        {
            animators[actualPage].SetBool("Active", false);
            actualPage--;
            animators[actualPage].SetBool("Active", true);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Video");
        }
    }
}
