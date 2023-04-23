using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    AudioSource bgm;
    [SerializeField]
    AudioSource click;
    [SerializeField]
    AudioSource clear;

    public float BGMVolume
    {
        get
        {
            return bgm.volume;
        }
        set
        {
            bgm.volume = Mathf.Clamp01(value);
        }
    }

    public float ClickVolume
    {
        get
        {
            return click.volume;
        }
        set
        {
            click.volume = Mathf.Clamp01(value);
        }
    }

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
