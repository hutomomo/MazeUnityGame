using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Linq;
public class otamesiScript : MonoBehaviour
{
   /* public int max = 50;        //縦横のサイズ ※必ず奇数にすること
    public GameObject Cube = GameObject.CreatePrimitive(PrimitiveType.Cube);    //壁用オブジェクト

    // 内部パラメータ
    private enum CellType { Wall, Path };   //セルの種類
    private CellType[,] cells;
    private Vector2Int startPos;    //スタートの座標
    private Vector2Int goalPos;     //ゴールの座標

    private void Start()
    {

        cells = new CellType[max, max];       //マップ状態初期化
        startPos = GetStartPosition();        //スタート地点の取得

        //通路の生成
        goalPos = MakeMapInfo(startPos);      //初回はゴール地点を設定する


        var tmpStart = goalPos;                 //通路生成を繰り返して袋小路を減らす
        for (int i = 0; i < max * 5; i++)
        {
            MakeMapInfo(tmpStart);
            tmpStart = GetStartPosition();
        }

        //マップの状態に応じて壁と通路を生成する
        BuildDungeon();

    }


    // スタート地点の取得
    private Vector2Int GetStartPosition()
    {

        int randomX = Random.Range(0, max);                                                     //ランダムでx,yを設定
        int randomY = Random.Range(0, max);


        while (!(randomX % 2 == 1 && randomY % 2 == 1))                                         //x、yが両方共偶数になるまで繰り返す
        {
            randomX = Mathf.RoundToInt(Random.Range(0, max));
            randomY = Mathf.RoundToInt(Random.Range(0, max));
        }

        return new Vector2Int(randomX, randomY);
    }

    private Vector2Int MakeMapInfo(Vector2Int _startPos)                                        //マップ生成
    {

        var tmpStartPos = _startPos;                                                            //スタート位置配列を複製
        var movablePositions = GetMovablePositions(tmpStartPos);                                //移動可能な座標のリストを取得

        while (movablePositions != null)                                                        //移動可能な座標がなくなるまで探索を繰り返す
        {

            var tmpPos = movablePositions[Random.Range(0, movablePositions.Count)];             //移動可能な座標からランダムで1つ取得し通路にする
            cells[tmpPos.x, tmpPos.y] = CellType.Path;
            var xPos = tmpPos.x + (tmpStartPos.x - tmpPos.x) / 2;                               //元の地点と通路にした座標の間を通路にする
            var yPos = tmpPos.y + (tmpStartPos.y - tmpPos.y) / 2;
            cells[xPos, yPos] = CellType.Path;
            tmpStartPos = tmpPos;                                                               //移動後の座標を一時変数に格納し、再度移動可能な座標を探索する
            movablePositions = GetMovablePositions(tmpStartPos);
        }

        return tmpStartPos;                                                                     //探索終了時の座標を返す
    }

    private List<Vector2Int> GetMovablePositions(Vector2Int _startPos)                          //移動可能な座標のリストを取得する
    {

        var x = _startPos.x;                                                                    //可読性のため座標を変数に格納
        var y = _startPos.y;


        var positions = new List<Vector2Int> {                                                  //移動方向毎に2つ先のx,y座標を仮計算
            new Vector2Int(x, y + 2),
            new Vector2Int(x, y - 2),
            new Vector2Int(x + 2, y),
            new Vector2Int(x - 2, y)
        };

        var movablePositions = positions.Where(p => !IsOutOfBounds(p.x, p.y) && cells[p.x, p.y] == CellType.Wall);

        return movablePositions.Count() != 0 ? movablePositions.ToList() : null;　//動ける場所のリストを返す動ける場所がなくなったとき
    }



    private bool IsOutOfBounds(int x, int y) => (x < 0 || y < 0 || x >= max || y >= max);       //与えられたx、y座標が範囲外の場合真を返す

    private void BuildDungeon()                                                                //パラメータに応じてオブジェクトを生成する
    {
        GameObject wall = (GameObject)Resources.Load("WallCube");
        //縦横1マスずつ大きくループを回し、外壁とする
        for (int i = -1; i <= max; i++)
        {
            for (int j = -1; j <= max; j++)
            {
                if (IsOutOfBounds(i, j) || cells[i, j] == CellType.Wall)                        //範囲外、または壁の場合に壁オブジェクトを生成する
                {
                    var wallObj = Instantiate(wall, new Vector3(i, 1, j), Quaternion.identity);
                    wallObj.transform.parent = this.transform;
                }
            }
        }
    }*/
}