using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 各スクリプト説明 : MonoBehaviour
{
    /*各スクリプトの役割
     * ClearScript : 各ステージのClearWindowにアタッチ。ゲームクリア判定と、その後のフェードアウトアニメーション再生、
     * 　　　　　　　　ステージ解放処理の実行
     * DragObj1~4 : 各ゲームの4つのアイテムにそれぞれアタッチ。ドラック&ドロップとその際のImageサイズ変更、
     * 　　　　　　　　パズルに正解した場合はItem,Hint,Jdgeオブジェクトを削除しPanelを表示する
     * StageManager : ClearScriptから実行するNextStageメソッドのみ。プレイ中のステージのBuildIndexと
     * 　　　　　　　　　StageUnlock値を比較しステージを解放
     * 
     * Instructor : stage1にのみ用意されたゲーム説明
     * SceneController : ステージ解放や各ステージへの遷移以外はこのスクリプトで管理
     * 　　　　　　　　　　・スタート→選択画面への遷移
     * 　　　　　　　　　　・各ステージ→選択画面への遷移(&遷移前の確認画面の表示)
     * SoundManager : ゲーム全体のサウンド管理,
     * 　　　　　　　　ゲームスタート時生成されDontDestroyOnLoadでシーンを跨いだサウンド管理が可能
     * StageSelectController : ステージ解放のためのメソッド、クリア後のボタン表示を変更するメソッド
     * 　　　　　　　　　　　　　　ステージ選択画面から、各ステージへの遷移するメソッド
     * 
     */
}
