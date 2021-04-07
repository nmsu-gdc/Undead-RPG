using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1;


    // Update is called once per frame
    void Update()
    {

        Vector3 moveTowards = transform.position;

        if (Input.GetKey("w"))
        {
            moveTowards.z += speed * Time.deltaTime;
        }

        if (Input.GetKey("s"))
        {
            moveTowards.z -= speed * Time.deltaTime;

        }

        if (Input.GetKey("a"))
        {
            moveTowards.x -= speed * Time.deltaTime;
        }

        if (Input.GetKey("d"))
        {
            moveTowards.x += speed * Time.deltaTime;
        }



        transform.position = Vector3.MoveTowards(transform.position, moveTowards, speed * Time.deltaTime);

    }
}
