using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour {
    public GameObject prefab;
    void Update()
    {
        Vector2 Position = new Vector2(Random.Range(-100f, 100f), Random.Range(10f, 35f));
        GameObject myObj = Instantiate(prefab, Position, Quaternion.identity);
        Destroy(myObj, 3);
    }
}
