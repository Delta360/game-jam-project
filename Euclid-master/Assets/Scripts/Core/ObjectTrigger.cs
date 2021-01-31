using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTrigger : MonoBehaviour
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
            TriggerObject.GetComponent<MeshCollider>().enabled = true;
            TriggerObject.GetComponent<MeshRenderer>().enabled = true;
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
