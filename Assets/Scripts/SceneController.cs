using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    GameObject poseWindow;

    // スタート画面からステージ選択画面へ進む //
    public void StartButton()
    {
        SceneManager.LoadScene("StageSelect");
    }

    // ステージ選択画面へ戻る前の確認 //
    public void Pose()
    {
        poseWindow.SetActive(true);
    }

    public void No()
    {
        poseWindow.SetActive(false);
    }
    // 各ステージから選択画面へ戻る //
    public void Yes()
    {
        SceneManager.LoadScene("StageSelect");
    }
}
