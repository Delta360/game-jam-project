using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableObjectTrigger : MonoBehaviour
{
    Renderer rend;
    [SerializeField] private GameObject TriggerObject;
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TriggerObject.GetComponent<MeshCollider>().enabled = false;
            TriggerObject.GetComponent<MeshRenderer>().enabled = false;
            rend.material.SetColor("_Color", Color.yellow);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            rend.material.SetColor("_Color", Color.red);
        }
    }
}
