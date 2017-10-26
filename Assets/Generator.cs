using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {

    public GameObject virtualBulletPrefab;

    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(virtualBulletPrefab) as GameObject;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            bullet.GetComponent<BulletController>().Shoot(worldDir.normalized * 2000);
        }
	}
}
