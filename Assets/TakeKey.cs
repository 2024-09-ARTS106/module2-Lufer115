using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeKey : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            this.gameObject.transform.SetParent(other.gameObject.transform, false);
            Vector3 handPos = other.gameObject.transform.Find("HandLocation").position;
            this.transform.position = handPos;

        }
    }

}
