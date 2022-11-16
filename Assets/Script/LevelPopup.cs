using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPopup : MonoBehaviour
{

    [SerializeField] private GameObject btnLevelPrefab;
    [SerializeField] private GameObject gridLayout;
    [SerializeField] private int levelUWant;
    [SerializeField] private string[] textUWant;

    //215.7 = số 1 button chiếm grid

    // Start is called before the first frame update
    void Start()
    {   
        SpawnSizeGrid(levelUWant);
        spawnLevelBtn(levelUWant);
    }

    void spawnLevelBtn(int idx){
        for(int i=0; i<idx; i++){
            GameObject game = Instantiate(btnLevelPrefab, new Vector3(0,0,0), Quaternion.identity);
            game.transform.SetParent(gridLayout.transform);
            game.name = (i+1).ToString();
        }   
    }

    void SpawnSizeGrid(int idx){
        RectTransform rt = gridLayout.GetComponent<RectTransform>();
        if(idx > 5){
            rt.position = new Vector3(540, 219f * idx / -2, 0);
            rt.sizeDelta = new Vector2(656.29f, 220.7f * idx);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
