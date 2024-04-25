using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearbyOpenDoor : MonoBehaviour
{
    [SerializeField] AudioSource OpenSFX;
    [SerializeField] AudioSource CloseSFX;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider Other)
    {
        if (Other.CompareTag("Player"))
        {
            this.GetComponent<Animator>().SetBool("PlayerNear", true);
            OpenSFX.Play();
            //Debug.Log("In Radius");
        }
    }
    private void OnTriggerExit(Collider Other)
    {
        if (Other.CompareTag("Player"))
        {
            this.GetComponent<Animator>().SetBool("PlayerNear", false);
            CloseSFX.Play();
        }
    }
}
