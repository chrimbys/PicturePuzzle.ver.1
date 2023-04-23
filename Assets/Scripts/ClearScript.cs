using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ClearScript : MonoBehaviour
{
    public bool flag1, flag2, flag3, flag4;
    Animation anime;

    [SerializeField]
    GameObject clearText;

    SoundManager soundManager;

    void Start()
    {
        anime = GetComponent<Animation>();
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
    }

    void Update()
    {
        if(flag1 == true && flag2 == true && flag3 == true && flag4 == true)
        {
            anime.Play();
            flag1　= false;
            if(SceneManager.GetActiveScene().name == "Stage1")
            {
                PlayerPrefs.SetInt("score", 1);
                PlayerPrefs.Save();
            }
            if (SceneManager.GetActiveScene().name == "Stage2")
            {
                PlayerPrefs.SetInt("score", 2);
                PlayerPrefs.Save();
            }
            if (SceneManager.GetActiveScene().name == "Stage3")
            {
                PlayerPrefs.SetInt("score", 3);
                PlayerPrefs.Save();
            }
            if (SceneManager.GetActiveScene().name == "Stage4")
            {
                PlayerPrefs.SetInt("score", 4);
                PlayerPrefs.Save();
            }
            if (SceneManager.GetActiveScene().name == "Stage5")
            {
                PlayerPrefs.SetInt("score", 5);
                PlayerPrefs.Save();
            }
            if (SceneManager.GetActiveScene().name == "Stage6")
            {
                PlayerPrefs.SetInt("score", 6);
                PlayerPrefs.Save();
            }
            if (SceneManager.GetActiveScene().name == "Stage7")
            {
                PlayerPrefs.SetInt("score", 7);
                PlayerPrefs.Save();
            }
            if (SceneManager.GetActiveScene().name == "Stage8")
            {
                PlayerPrefs.SetInt("score", 8);
                PlayerPrefs.Save();
            }
            if (SceneManager.GetActiveScene().name == "Stage9")
            {
                PlayerPrefs.SetInt("score", 9);
                PlayerPrefs.Save();
            }
            if (SceneManager.GetActiveScene().name == "Stage10")
            {
                PlayerPrefs.SetInt("score", 10);
                PlayerPrefs.Save();
            }

            if (SceneManager.GetActiveScene().name == "Stage11")
            {
                PlayerPrefs.SetInt("score", 11);
                PlayerPrefs.Save();
            }

            if (SceneManager.GetActiveScene().name == "Stage12")
            {
                PlayerPrefs.SetInt("score", 12);
                PlayerPrefs.Save();
            }
        }
    }

    void StartFadeOut()
    {
        clearText.SetActive(true);
        soundManager.Playclear();
    }
}
