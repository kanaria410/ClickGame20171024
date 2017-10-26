using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    private void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().isKinematic = true;
    }

    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
