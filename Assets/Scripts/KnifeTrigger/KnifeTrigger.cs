using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeTrigger : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _knifeRigidBody;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent<PlayerDeath>(out PlayerDeath playerDeath))
        {
            _knifeRigidBody.gravityScale = 9f;
        }
    }
}
