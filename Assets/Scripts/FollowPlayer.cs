using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] GameObject player;
    Vector3 offsetBack = new Vector3(0, 6f, -8f);
    Vector3 offsetFront = new Vector3(0, 4.5f, 0f);

    [SerializeField] private bool flag = true;


    // used LateUpdate for smooth experience
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.V) && flag)
        {
            flag = false;
        }
        else if (Input.GetKeyDown(KeyCode.V) && !flag)
        {
            flag = true;
        }


        if (flag)
        {
            transform.position = player.transform.position + offsetBack;
        }
        else
        {
            transform.position = player.transform.position + offsetFront;
        }
    }
}
