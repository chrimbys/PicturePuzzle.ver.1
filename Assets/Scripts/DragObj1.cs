using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragObj1 : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IDropHandler
{

    private Vector2 prevPos; //保存しておく初期position
    private RectTransform rectTransform; // 移動したいオブジェクトのRectTransform
    private RectTransform parentRectTransform; // 移動したいオブジェクトの親(Panel)のRectTransform

    [SerializeField]
    GameObject Panel1;//パズルが正解の時、表示される
    [SerializeField]
    GameObject Pos1;//このオブジェクト範囲内でドロップするとパズル正解となる(judge)
    [SerializeField]
    GameObject Hint1;//ヒントとしてパネルの影を表示
    [SerializeField]
    ClearScript clearScript;//パズル正解の場合、左スクリプトのflag1をtrueにする
  
    private Image image;//imageサイズ変更に使用
    float width = 150;
    float height = 150;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        parentRectTransform = rectTransform.parent as RectTransform;
        image = GetComponent<Image>();
    }


    //ドラッグ開始時の処理
    public void OnBeginDrag(PointerEventData eventData)
    {
        //ドラッグ前の位置を記憶しておく
        //RectTransformの場合はpositionではなくanchoredPositionを使う
        //imageを元のサイズに戻す
        prevPos = rectTransform.anchoredPosition;
        image.SetNativeSize();

    }

    //ドラッグ中の処理
    public void OnDrag(PointerEventData eventData)
    {
        //eventData.positionから、親に従うlocalPositionへの変換を行う
        //オブジェクトの位置をlocalPositionに変更する
        Vector2 localPosition = GetLocalPosition(eventData.position);
        rectTransform.anchoredPosition = localPosition;
    }

    //ドラッグ終了時の処理
    public void OnEndDrag(PointerEventData eventData)
    {
        //オブジェクトをドラッグ前の位置に戻す
        rectTransform.anchoredPosition = prevPos;
        rectTransform.sizeDelta = new Vector2(width, height);
    }

    // ScreenPositionからlocalPositionへの変換関数
    private Vector2 GetLocalPosition(Vector2 screenPosition)
    {
        Vector2 result = Vector2.zero;

        // screenPositionを親の座標系(parentRectTransform)に対応するよう変換する
        RectTransformUtility.ScreenPointToLocalPointInRectangle(parentRectTransform, screenPosition, Camera.main, out result);

        return result;
    }

    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        var raycastResults = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, raycastResults);

        foreach (var hit in raycastResults)
        {
            // もし DroppableField1の上なら、その位置に固定する
            if (hit.gameObject.CompareTag("Droppablefield1"))
            {
                transform.position = hit.gameObject.transform.position;
                this.enabled = false;
                //Panelをアクティブ、flagをtrueにして、item,Hint,judgeを消す
                Panel1.SetActive(true);
                clearScript.flag1 = true;
                Destroy(Pos1);
                Destroy(Hint1);
                Destroy(this.gameObject);
            }
        }
    }
}
