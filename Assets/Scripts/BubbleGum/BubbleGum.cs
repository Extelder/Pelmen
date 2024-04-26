using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleGum : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent<PlayerMove>(out PlayerMove playerMove))
        {
            playerMove.CurrentSpeed = 0;
        }
    }
}
