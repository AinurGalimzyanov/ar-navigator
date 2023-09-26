using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayActive : MonoBehaviour
{
    private Renderer MarkerRender;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("UnSelected") || collision.gameObject.CompareTag("Selected"))
        {
            MarkerRender = collision.gameObject.GetComponent<Renderer>();
            MarkerRender.enabled = true;
        }
    }


    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("UnSelected") || collision.gameObject.CompareTag("Selected"))
        {
            MarkerRender = collision.gameObject.GetComponent<Renderer>();
            MarkerRender.enabled = false;
        }
    }

}
