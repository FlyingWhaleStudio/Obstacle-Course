using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAngle = 0f;
    [SerializeField] float yAngle = 0f;
    [SerializeField] float zAngle = 0f;

    // Update is called once per frame
    void Update()
    {
        float x = xAngle * Time.deltaTime;
        float y = yAngle * Time.deltaTime;
        float z = zAngle * Time.deltaTime;

        transform.Rotate(x, y, z);
    }
}
