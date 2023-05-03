using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Instructor : MonoBehaviour
{
    //public float fadeSpeed;        //透明度が変わるスピードを管理
    //float red, green, blue, alfa;   //パネルの色、不透明度を管理

    bool isFadeIn;  //フェードアウト処理の開始、完了を管理するフラグ
    bool isFadeOut;
    //Image fadeImage;                //透明度を変更するパネルのイメージ
    Animation anime;

    [SerializeField]
    GameObject startText;

    float s;

    void Start()
    {
        anime = GetComponent<Animation>();
        /*fadeImage = GetComponent<Image>();
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;*/
        Invoke("StartFadeIn", 1f);
        //isFadeIn = true;
    }

    private void Update()
    {
        /*if(isFadeIn == true)
        {
            StartFadeIn();
        }
        else if (isFadeOut == true)
        {
            StartFadeOut();
        }*/
    }

    void StartFadeIn()
    {
        anime.Play();
        /*fadeImage.enabled = true;  // a)パネルの表示をオンにする
        alfa += fadeSpeed * Time.deltaTime;         // b)不透明度を徐々にあげる
        SetAlpha();               // c)変更した透明度をパネルに反映する
        if (alfa >= 0.6)
        {
            isFadeOut = false;
            startText.SetActive(true);
        }*/

    }

    void StartFadeOut()
    {
        startText.SetActive(true);
        Destroy(this.gameObject, 3f);
    }
    /*void SetAlpha()
    {
        fadeImage.color = new Color(red, green, blue, alfa);
    }*/
}
