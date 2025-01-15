using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgroundparallax : MonoBehaviour
{

    private float startpos, length;
    public GameObject camera;
    public float parallaxEffect;


    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = camera.transform.position.x * parallaxEffect;
        float movement = camera.transform.position.x * (1 - parallaxEffect);
        transform.position = new Vector3(startpos + distance, transform.position.y, transform.position.z);


        if (movement > startpos + length)
        {
            startpos += length;
        } else if(movement < startpos - length)
        {
            startpos -= length;
        }
    }

}
