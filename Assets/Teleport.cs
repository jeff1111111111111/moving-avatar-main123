using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        Player.transform.position = teleportTarget.transform.position;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
