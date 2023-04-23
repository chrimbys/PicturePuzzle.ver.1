using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveData : MonoBehaviour
{
    public int score;

    [SerializeField]
    Button stage2, stage3, stage4, stage5, stage6,
               stage7, stage8, stage9, stage10, stage11, stage12;
    [SerializeField]
    GameObject mask1, mask2, mask3, mask4, mask5, mask6,
               mask7, mask8, mask9, mask10, mask11, mask12;

    void Start()
    {
        score = PlayerPrefs.GetInt("score",0);
    }

    // Update is called once per frame
    void Update()
    {
        if(score >= 1)
        {
            mask1.SetActive(true);
            stage2.interactable = true;
        }
        if (score >= 2)
        {
            mask2.SetActive(true);
            stage3.interactable = true;
        }
        if (score >= 3)
        {
            mask3.SetActive(true);
            stage4.interactable = true;
        }
        if (score >= 4)
        {
            mask4.SetActive(true);
            stage5.interactable = true;
        }
        if (score >= 5)
        {
            mask5.SetActive(true);
            stage6.interactable = true;
        }
        if (score >= 6)
        {
            mask6.SetActive(true);
            stage7.interactable = true;
        }
        if (score >= 7)
        {
            mask7.SetActive(true);
            stage8.interactable = true;
        }
        if (score >= 8)
        {
            mask8.SetActive(true);
            stage9.interactable = true;

        }
        if (score >= 9)
        {
            mask9.SetActive(true);
            stage10.interactable = true;
        }
        if (score >= 10)
        {
            mask10.SetActive(true);
            stage11.interactable = true;
        }
        if (score >= 11)
        {
            mask11.SetActive(true);
            stage12.interactable = true;
        }
        if (score >= 12)
        {
            mask12.SetActive(true);
        }
    }
}
