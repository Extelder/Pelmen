using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent<PlayerDeath>(out PlayerDeath playerDeath))
        {
            playerDeath.Death();
        }
    }
}
