using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;
    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        Vector3 force = RandomForce();
        targetRb.AddForce(force, ForceMode.Impulse);
        Vector3 torque = RandomTorque();
        targetRb.AddTorque(torque);
        Vector3 position = RandomPosition();
        transform.position = position;
    }
    private Vector3 RandomPosition()
    {
        return new Vector3(Random.Range(-4, 4), -6, 0);
    }
    private Vector3 RandomTorque()
    {
        float x = Random.Range(-10, 10);
        float y = Random.Range(-10, 10);
        float z = Random.Range(-10, 10);

        return new Vector3(x, y, z);
    }

    private Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(12, 16);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
