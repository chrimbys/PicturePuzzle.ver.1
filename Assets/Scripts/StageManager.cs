using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StageManager : MonoBehaviour
{
    public void NextStage()
    {
        //StageUnlock値取得
        int StageUnlock = PlayerPrefs.GetInt("StageUnlock");
        //現在のシーンのビルドインデックスを取得
        int clearScene = SceneManager.GetActiveScene().buildIndex;
        //Debug.Log("現在のStageUnlockの値は" + StageUnlock);
        //Debug.Log("現在のシーンのIndex値は" + clearScene);
        if (clearScene < 14)
        {
            if(StageUnlock < clearScene)//前のステージをクリアしてもクリア表示がリセットされない
            {
                PlayerPrefs.SetInt("StageUnlock", clearScene);
            }
        }
    }
}
