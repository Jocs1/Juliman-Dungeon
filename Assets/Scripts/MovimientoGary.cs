using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoGary : MonoBehaviour
{
    public Rigidbody2D rbd;

    private float _velLeñador;


    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
