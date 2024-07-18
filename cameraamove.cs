using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraamove : MonoBehaviour
{

    public GameObject bird;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position-bird.transform.position ;
    }

    // Update is called once per frame
    void Update()
    {
        if (playermove.gameOver) return;
        transform.position = new Vector3(
         bird.transform.position.x + offset.x,
         transform.position.y,
         transform.position.z
         );
    }
}
