using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour {
    public GameObject prefab;
    public GameObject Stones;
    int StoneCount = 0;
    void Start()
    {
        StoneCount = Random.Range(0,100);
    }
    void Update()
    {
        Vector2 Position = new Vector2(Random.Range(-100f, 100f), Random.Range(10f, 35f));
        GameObject myObj = Instantiate(prefab, Position, Quaternion.identity);
        Destroy(myObj, 3);
        if (StoneCount >= 66)
        {
            GameObject stone = Instantiate(Stones, Position, Quaternion.identity);
        }
            
    }
}
