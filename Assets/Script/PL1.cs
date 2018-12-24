using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PL1 : MonoBehaviour {

    public GameObject bullet;
    private Rigidbody pl1;
    private float time_b = 4;
    

    void Start ()
    {
        pl1 = this.GetComponent<Rigidbody>();
	}


    void Update ()
    {
        if (Input.GetKey(KeyCode.W) && pl1.transform.position.y < -4)
        {
            pl1.AddForce(0,40,0);
        }

        if (Input.GetKey(KeyCode.D) && time_b > 2f)
        {
            Instantiate(bullet, new Vector3(this.transform.position.x+1, this.transform.position.y, this.transform.position.z), Quaternion.identity);
            time_b = 0;
        }

        time_b += Time.deltaTime;
	}

    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }
}
