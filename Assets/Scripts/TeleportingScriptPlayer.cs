using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TeleportingScriptPlayer : MonoBehaviour
{
    [SerializeField] GameObject TeleportPos;
    [SerializeField] GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("k"))
        {
            Debug.Log("K key was pressed");
            Player.transform.position = TeleportPos.transform.position;
        }
    }

}
