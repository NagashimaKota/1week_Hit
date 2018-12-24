using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet1 : MonoBehaviour {

    public float player = 1;
    private Transform tama1;

    void Start ()
    {
        tama1 = this.GetComponent<Transform>();
	}


    void Update ()
    {
        tama1.Translate(0.1f * player,0,0);

        if (!GetComponent<Renderer>().isVisible)
        {
            Destroy(this.gameObject);
        }
    }


}
