using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1.0f;
    public GameObject tiro;
    public Transform offsetTiro;
    private float nextFire = 0.0f;
    public float fireRate = 0.25f;
    public int tirosPorRajada = 3;
    private float proximaRajada = 0;
    public float intervalaRajadas = 0.5f;
    private int totalTiros = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimentacao();

        LimiteDeTela();
        Atirar();
    }

    private void Movimentacao()
    {
        var moveY = Input.GetAxis("Horizontal");
        var moveX = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * speed * Time.deltaTime * moveX);
        transform.Translate(Vector3.right * speed * Time.deltaTime * moveY);
    }

    private void Atirar()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time > nextFire && Time.time > proximaRajada)
        {
            nextFire = Time.time + fireRate;
            Instantiate(tiro, offsetTiro.position, Quaternion.identity);

            totalTiros = totalTiros + 1; //totalTiros++

            if (totalTiros == tirosPorRajada)
            {
                proximaRajada = Time.time + intervalaRajadas;
                totalTiros = 0;
            }
        }
    }

    private void LimiteDeTela()
    {
        if (transform.position.x > 8.858218f)

        {
            var newposition = transform.position;
            newposition.x = 8.858218f;
            transform.position = newposition;
        }

        if (transform.position.y > 5.724001f)
        {
            var newposition = transform.position;
            newposition.y = 5.724001f;
            transform.position = newposition;
        }

        if (transform.position.x < -8.773135f)
        {
            var newpositon = transform.position;
            newpositon.x = -8.773135f;
            transform.position = newpositon;
        }

        if (transform.position.y < -3.715358f)
        {
            var newposition = transform.position;
            newposition.y = -3.715358f;
            transform.position = newposition;
        }
    }
}
