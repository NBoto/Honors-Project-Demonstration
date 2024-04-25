using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSteam : MonoBehaviour
{
    [SerializeField] ParticleSystem Particles;
    [SerializeField] AudioSource Audio;
    // Start is called before the first frame update
    void Start()
    {
        Particles.Stop();
        Audio.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider Other)
    {
        if (Other.CompareTag("Player"))
        {
            Particles.Play();
            Audio.Play();
            //Debug.Log("In Radius");
        }
    }
    private void OnTriggerExit(Collider Other)
    {
        if (Other.CompareTag("Player"))
        {
            Particles.Stop();
            Audio.Stop();
        }
    }
}
