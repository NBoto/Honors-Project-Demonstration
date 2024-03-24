using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TeleportingScript : MonoBehaviour
{
    [SerializeField] GameObject TeleportPos;
    [SerializeField] GameObject Camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.position = TeleportPos.transform.position;
            Camera.transform.rotation = TeleportPos.transform.rotation;
        }
    }
}
