using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Collider collider = GetComponent<Collider>();

        if(collider != null)
        {
            collider.enabled = false;
        }
    }

}
