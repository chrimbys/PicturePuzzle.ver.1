using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragObj4 : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IDropHandler
{

    private Vector2 prevPos; //保存しておく初期position
    private RectTransform rectTransform; // 移動したいオブジェクトのRectTransform
    private RectTransform parentRectTransform; // 移動したいオブジェクトの親(Panel)のRectTransform

    [SerializeField]
    GameObject Panel4;
    [SerializeField]
    GameObject Pos4;
    [SerializeField]
    GameObject Hint4;
    [SerializeField]
    ClearScript clearScript;
  
    private Image image;
    float width = 150;
    float height = 150;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        parentRectTransform = rectTransform.parent as RectTransform;
        image = GetComponent<Image>();
    }


    // ドラッグ開始時の処理
    public void OnBeginDrag(PointerEventData eventData)
    {
        // ドラッグ前の位置を記憶しておく
        // RectTransformの場合はpositionではなくanchoredPositionを使う
        prevPos = rectTransform.anchoredPosition;
        image.SetNativeSize();
    }

    // ドラッグ中の処理
    public void OnDrag(PointerEventData eventData)
    {
        // eventData.positionから、親に従うlocalPositionへの変換を行う
        // オブジェクトの位置をlocalPositionに変更する
        Vector2 localPosition = GetLocalPosition(eventData.position);
        rectTransform.anchoredPosition = localPosition;

    }

    // ドラッグ終了時の処理
    public void OnEndDrag(PointerEventData eventData)
    {
        // オブジェクトをドラッグ前の位置に戻す
        rectTransform.anchoredPosition = prevPos;
        rectTransform.sizeDelta = new Vector2(width, height);
    }

    // ScreenPositionからlocalPositionへの変換関数
    private Vector2 GetLocalPosition(Vector2 screenPosition)
    {
        Vector2 result = Vector2.zero;

        // screenPositionを親の座標系(parentRectTransform)に対応するよう変換する.
        RectTransformUtility.ScreenPointToLocalPointInRectangle(parentRectTransform, screenPosition, Camera.main, out result);

        return result;
    }

    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        var raycastResults = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, raycastResults);

        foreach (var hit in raycastResults)
        {
            // もし DroppableField の上なら、その位置に固定する
            if (hit.gameObject.CompareTag("Droppablefield4"))
            {
                transform.position = hit.gameObject.transform.position;
                this.enabled = false;
                //羽子板パネルをアクティブにして、itemとpicjudgeを消す
                Panel4.SetActive(true);
                Destroy(Pos4);
                Destroy(Hint4);
                clearScript.flag4 = true;
                Destroy(this.gameObject);
            }
        }
    }
}
