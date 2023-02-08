using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var moveY= Input.GetAxis("Horizontal");
        var moveX= Input.GetAxis("Vertical");
        print(moveX);
        transform.Translate(Vector3.up * Speed * Time.deltaTime * moveX);
        transform.Translate(Vector3.right * Speed * Time.deltaTime * moveY );
    }
}
