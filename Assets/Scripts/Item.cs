using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CollectItem();
        }
    }

    private void CollectItem()
    {
        TimerManager.Instance.AddTime();
        TimerManager.Instance.AddCoins();
        Destroy(gameObject);
    }
}
