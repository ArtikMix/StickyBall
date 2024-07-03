using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.transform.parent = other.gameObject.transform.GetChild(0);
            this.GetComponent<BoxCollider>().enabled = false;
            other.gameObject.transform.localScale += Vector3.one * 0.1f;

            other.gameObject.transform.GetChild(0).localScale -= Vector3.one * 0.1f;
        }
    }
}
