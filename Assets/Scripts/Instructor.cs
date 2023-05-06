using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Instructor : MonoBehaviour
{
    //bool isFadeIn;  //フェードアウト処理の開始、完了を管理するフラグ
    //bool isFadeOut;
    Animation anime;

    [SerializeField]
    GameObject startText;//説明文

    void Start()
    {
        anime = GetComponent<Animation>();
        Invoke("StartFadeIn", 1.0f);
    }

    void StartFadeIn()
    {
        anime.Play();//フェードインアニメーション
    }

    void StartFadeOut()//Animationで実行設定
    {
        startText.SetActive(true);
        Destroy(this.gameObject, 3f);
    }
}
