using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelPopup : MonoBehaviour
{

    [SerializeField] private GameObject btnLevelPrefab;
    [SerializeField] private GameObject gridLayout;
    [SerializeField] private int levelUWant;

    public string[] textUWant;

    //215.7 = số 1 button chiếm grid

    // Start is called before the first frame update
    void Start()
    {   
        SpawnSizeGrid(levelUWant);
        spawnLevelBtn(levelUWant);
    }

    void spawnLevelBtn(int idx){
        for(int i=0; i<idx; i++){
            GameObject btn = Instantiate(btnLevelPrefab, new Vector3(0,0,0), Quaternion.identity);
            btn.transform.SetParent(gridLayout.transform);
            btn.name = (i+1).ToString();
            for(int j=0; j<btn.transform.childCount; j++){
                Transform curChild = btn.transform.GetChild(j);
                if(curChild.name.Equals("TittleBtnText")){
                    int ran = Random.Range(0,textUWant.Length);
                    curChild.GetComponent<TextMeshProUGUI>().text = textUWant[ran];
                }
            }
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
