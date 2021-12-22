using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {

            CheckpointManager.spawnpoint = transform.position;
            Destroy(gameObject);
        }
    }
}