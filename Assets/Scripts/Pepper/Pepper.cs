using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pepper : MonoBehaviour
{
    [SerializeField] private GameObject _peppercorn;
    [SerializeField] private Transform _pepperCornPlace;
    [SerializeField] private float _delay;

    private void Start()
    {
        StartCoroutine(PourOut());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    private IEnumerator PourOut()
    {
        while (true)
        {
            Instantiate(_peppercorn, _pepperCornPlace.position, Quaternion.identity);
            yield return new WaitForSeconds(_delay);
        }
    }
}
