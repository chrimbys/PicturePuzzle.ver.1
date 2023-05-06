using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    AudioSource bgm;//BGM
    [SerializeField]
    AudioSource click;//タップorクリック時
    [SerializeField]
    AudioSource clear;//stageクリア時

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            click.Play();
        }
    }

    public void Playclear()
    {
        clear.Play();
    }

    

}
