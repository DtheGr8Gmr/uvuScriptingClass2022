using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatUp : MonoBehaviour
{

    public float floatSpeed;
    public float upperBound;

    private BalloonScript balloon;

    // Start is called before the first frame update
    void Start()
    {
        balloon = GetComponent<BalloonScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * floatSpeed * Time.deltaTime);

        if(transform.position.y >upperBound)
        {
            Destroy(gameObject);
        }
    }
}
