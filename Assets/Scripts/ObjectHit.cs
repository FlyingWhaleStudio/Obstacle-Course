using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    [SerializeField] GameObject other;
    MeshRenderer renderer1;
    MeshRenderer renderer2;

    // Start is called before the first frame update
    void Start()
    {
        renderer1 = GetComponent<MeshRenderer>();
        if (other != null)
        {
            renderer2 = other.GetComponent<MeshRenderer>();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            renderer1.material.color = Color.red;

            if (other != null)
            {
                renderer2.material.color = Color.red;
            }

            gameObject.tag = "Hit";
        }
    }
}
