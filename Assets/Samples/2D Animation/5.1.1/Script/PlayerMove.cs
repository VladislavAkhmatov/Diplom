using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 0.1f;
    private Animator animate;


    private void Start()
    {
        animate = gameObject.GetComponent<Animator>();
    }

    private void FixedUpdate()
    {

    }

    private void Update()
    {
        Vector3 pos = transform.position;
        Vector3 characterScale = transform.localScale;
        animate.SetFloat("Speed", 0);

        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
            animate.SetFloat("Speed", 1);
        }

        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
            animate.SetFloat("Speed", 1);
        }

        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
            characterScale.x = -1;
            animate.SetFloat("Speed", 1);
        }

        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
            characterScale.x = 1;
            animate.SetFloat("Speed", 1);
        }
        transform.position = pos;
        transform.localScale = characterScale;
    }
}
