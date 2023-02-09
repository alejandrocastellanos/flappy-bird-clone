using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawnerScript : MonoBehaviour
{
    public GameObject ground;
    public float spawnRate = 5;

    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnGround();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnGround();
            timer = 0;
        }

    }

    void spawnGround()
    {
        Instantiate(ground, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
    }
}
