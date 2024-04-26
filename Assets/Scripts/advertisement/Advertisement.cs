using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Advertisement : MonoBehaviour
{
    [SerializeField] private StartAdvertisement _startAdvertisement;

    private void OnEnable()
    {
        _startAdvertisement.ShowAD();
    }
}
