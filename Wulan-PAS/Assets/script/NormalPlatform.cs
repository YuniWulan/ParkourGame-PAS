using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalPlatform : MonoBehaviour
{

    public GameObject platform;
    public static AudioClip earnSound;
    static AudioSource audioSrc;
    bool isHere = false;
    



    void Start()
    {
        ChangeColor(Color.grey);
        earnSound = Resources.Load<AudioClip>("earnSound");
        audioSrc = GetComponent<AudioSource>();
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        print("Overlap");
        
        ChangeColor(Color.green);

        if(isHere == false)
        {
            audioSrc.PlayOneShot(earnSound);

            isHere = true;
            ScoreUI.scores += 1;
        }


        

    }

    private void OnTriggerExit(Collider other)
    {
       
        ChangeColor(Color.grey);
    }

    private void ChangeColor(Color color)
    {
        var cubeRenderer = platform.GetComponent<Renderer>();

        cubeRenderer.material.SetColor("_Color", color);
    }

}
