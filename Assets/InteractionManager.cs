using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Cube;
using static PickUpManager;


public class InteractionManager : MonoBehaviour
{
    public static InteractionManager Instance { get; set; }

    public Cube hovered = null;

    public void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    private void Update()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {
            GameObject objectHitByRayCast = hit.transform.gameObject;

            if (objectHitByRayCast.GetComponent<Cube>())
            {
                hovered = objectHitByRayCast.gameObject.GetComponent<Cube>();
                hovered.GetComponent<Outline>().enabled = true;

                if (Input.GetKeyDown(KeyCode.F))
                {
                    PickUpManager.Instance.PickUpObject(objectHitByRayCast.gameObject); 
                }
            }
            else
            {
                if (hovered)
                {
                    hovered.GetComponent<Outline>().enabled = false;
                }
            }
        }
    }
}
