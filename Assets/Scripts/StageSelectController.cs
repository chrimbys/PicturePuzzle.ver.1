using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StageSelectController : MonoBehaviour
{
    [SerializeField]
    Button[] stageButton; //ボタン配列
    [SerializeField]
    GameObject[] mask; //クリア表示配列
   
    void Start()
    {
        int stageUnlock = PlayerPrefs.GetInt("StageUnlock", 1);//初期値
        Debug.Log("stageUnlockの値は" + stageUnlock);
        //ボタンの有効化
        for (int i = 0; i < stageButton.Length; i++)
        {
            Debug.Log(i + "回目");
            if (i < stageUnlock)
            {
                stageButton[i].interactable = true;
                Debug.Log("ボタンtrue");
            }
            else
            {
                stageButton[i].interactable = false;
                Debug.Log("ボタンfalse");
            }
        }
        if(stageUnlock > 1)
        {
            for (int j = 0; j < mask.Length; j++)
            {
                if (stageUnlock - j > 1)
                {
                    mask[j].SetActive(true);
                    Debug.Log("マスクtrue: " + j);
                }
            }
        }
        else
        {
            Debug.Log("mask実行してないよ");
        }
    }
    //↓BuildSettingsのScenesInBuildの数字が対応している↓
    public void StageSelect(int stage)
    {
        SceneManager.LoadScene(stage);
    }
}
