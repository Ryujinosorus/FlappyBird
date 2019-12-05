using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuyau : MonoBehaviour {
    [SerializeField]
    float spawnTime, nextSpawn;
    bool haveSpawn=false;

	void Start () {
        spawnTime = Time.time;
        Destroy(gameObject, 5);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.left*Time.deltaTime);
        if(Time.time>spawnTime+nextSpawn&& !haveSpawn)
        {
            GameObject go = Instantiate(gameObject,new Vector3(2,Random.Range(-0.21f,-0.8f)),Quaternion.identity);
            haveSpawn = true;
        }
	}
}
