using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpinPropeller : MonoBehaviour
{

    [SerializeField] float rotateSpeed = 10f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, rotateSpeed);
    }
}
