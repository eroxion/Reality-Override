using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpManager : MonoBehaviour
{
    public static PickUpManager Instance { get; set; }

    public void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void PickUpObject(GameObject PickedUpItem)
    {
        Destroy(PickedUpItem);
    }
}
