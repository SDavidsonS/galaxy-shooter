using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo : MonoBehaviour

{
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NewMethod();
        LimiteInimigo();
    }

    private void NewMethod()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    private void LimiteInimigo()
    {
        if (transform.position.y < -7)
        {
            var newPosition = transform.position;
            newPosition.y = 8;
            newPosition.x = Random.Range(-9, 9);
            transform.position = newPosition;
        }
    }
}
