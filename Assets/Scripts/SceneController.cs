using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    GameObject poseWindow;

    // スタート画面 //
    public void StartButton()
    {
        SceneManager.LoadScene("StageSelect");
    }

    // ステージ選択画面 //
    public void Button1()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void Button2()
    {
        SceneManager.LoadScene("Stage2");
    }

    public void Button3()
    {
        SceneManager.LoadScene("Stage3");
    }

    public void Button4()
    {
        SceneManager.LoadScene("Stage4");
    }

    public void Button5()
    {
        SceneManager.LoadScene("Stage5");
    }

    public void Button6()
    {
        SceneManager.LoadScene("Stage6");
    }

    public void Button7()
    {
        SceneManager.LoadScene("Stage7");
    }

    public void Button8()
    {
        SceneManager.LoadScene("Stage8");
    }

    public void Button9()
    {
        SceneManager.LoadScene("Stage9");
    }

    public void Button10()
    {
        SceneManager.LoadScene("Stage10");
    }

    public void Button11()
    {
        SceneManager.LoadScene("Stage11");
    }

    public void Button12()
    {
        SceneManager.LoadScene("Stage12");
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
