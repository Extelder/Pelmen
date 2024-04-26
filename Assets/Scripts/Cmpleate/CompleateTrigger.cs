using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleateTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent<PlayerLevelCompleate>(out PlayerLevelCompleate playerLevelCompleate))
        {
            playerLevelCompleate.LevelCompleate();
        }
    }
}
