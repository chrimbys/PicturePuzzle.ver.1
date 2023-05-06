using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ClearScript : MonoBehaviour
{
    public bool flag1, flag2, flag3, flag4;//DragObj1~4パズル正解でtrue
    Animation anime;//フェードアウトのアニメーション

    [SerializeField]
    GameObject clearText;
    [SerializeField]
    StageManager stageManager;//ステージ解放のためNextStageメソッド指定

    SoundManager soundManager; //タイトルシーンで生成、オブジェクトを指定できなかったので検索

    void Start()
    {
        anime = GetComponent<Animation>();
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
    }

    void Update()
    {
        if(flag1 == true && flag2 == true && flag3 == true && flag4 == true)
        {
            flag1 = false;
            anime.Play();//フェードアウト
            stageManager.NextStage();
        }
    }
    //Animationにてメソッド実行設定
    void StartFadeOut()
    {
        clearText.SetActive(true);
        soundManager.Playclear();
    }
}
