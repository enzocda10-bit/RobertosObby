using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private Transform checkpoint;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out ReviveSystem reviveSystem))
        {
            reviveSystem.spawnPosition = checkpoint.position;
        }
    }
}
