using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int globalTileCount;
    public int globalTileMax;

    //public List<Transform> floorPrefabCount;
    
    // Start is called before the first frame update
    void Start()
    {
        globalTileMax = Mathf.RoundToInt(Random.Range(500, 1000));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        //for (int i = 0; i < floorPrefabCount.Count; i++)
        //{
        //    floorPrefabCount.Add(transform.position);
        //}
    }
}
