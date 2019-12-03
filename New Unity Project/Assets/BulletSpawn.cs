using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletSpawn : MonoBehaviour {
    public GameObject prefab;
    public GameObject Stone;
    int StoneCount = 0;
    public Text text;
    double counter = 0;
    public GameObject player;
    void Update()
    {
        counter += 0.1;
        text.text = "" + counter;
        StoneCount = Random.Range(0, 100);
        Vector2 Position = new Vector2(Random.Range(-100f, 100f), Random.Range(10f, 15f));
        Vector2 Position1 = new Vector2(Random.Range(-100f, 100f), Random.Range(10f, 15f));
        GameObject myObj = Instantiate(prefab, Position, Quaternion.identity);
        if (player.transform.position.y < -10)
        {
            UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
            Debug.Log(counter);
        }
        if (StoneCount >= 90)
        {
            GameObject stone = Instantiate(Stone, Position1, Quaternion.identity);
            Destroy(stone, 2);
        }
        Destroy(myObj, 2);
        
    }
}
