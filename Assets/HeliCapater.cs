using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliCapater : MonoBehaviour
{
    public AudioClip audioClip;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Help"))
        {
            print("calling helicapter");
            audioSource.Play();
        }

    }
}
