using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Text;
public class WallDeleteScript : MonoBehaviour
{

    /*public int max = 50;        //縦横のサイズ ※必ず奇数にすること


    // 2次元配列の迷路情報
    private int[,] Maze;
    private int Width = 51;
    private int Height = 51;
    // 通路・壁情報
    const int Path = 0;
    const int Wall = 1;

    // 穴掘り開始候補座標
    private List<Cell> StartCells;
    // 方向
    private enum Direction
    {
        Up = 0,
        Right = 1,
        Down = 2,
        Left = 3
    }

    private void Start()
    {
        GameObject Cube = GameObject.CreatePrimitive(PrimitiveType.Cube);    //壁用オブジェクト
        Debug.Log(Width);
        // 迷路情報を初期化
        Maze = new int[Width, Height];
        StartCells = new List<Cell>();
        for (int y = 0; y < Height; y++)
        {
            for (int x = 0; x < this.Width; x++)
            {
                if (x == 0 || y == 0 || x == this.Width - 1 || y == this.Height - 1)
                {
                    Maze[x, y] = Path;  // 外壁は判定の為通路にしておく(最後に戻す)
                }
                else
                {
                    Maze[x, y] = Wall;
                }
            }
        }
        Debug.Log(Maze);
        // 穴掘り開始
        Dig(1, 1);
        Debug.Log("終わった");
    }
    // 座標(x, y)に穴を掘る
    private void Dig(int x, int y)
    {
        Debug.Log("そこ");
        // 指定座標から掘れなくなるまで堀り続ける
        var rnd = new System.Random();

        directions.Add(Direction.Up);
        while (true)
        {
            //掘り進めることができる方向のリストを作成
            var directions = new List<Direction>();

            if (this.Maze[x, y - 1] == Wall)
            {
                if (this.Maze[x, y - 2] == Wall)
                {
                    directions.Add(Direction.Up);
                }
            }
            if (this.Maze[x + 1, y] == Wall)
            {
                if (this.Maze[x + 2, y] == Wall)
                {
                    directions.Add(Direction.Right);
                }
            }
            if (this.Maze[x, y + 1] == Wall)
            {
                if (this.Maze[x, y + 2] == Wall)
                {
                    directions.Add(Direction.Down);
                }
            }
            if (this.Maze[x - 1, y] == Wall)
            {
                if(this.Maze[x - 2, y] == Wall)
                {
                    directions.Add(Direction.Left);
                }
            }

            if (directions.Count == 0)
            {
                break;                     // 掘り進められない場合、ループを抜ける
            }
            SetPath(x, y);                                        // 指定座標を通路とし穴掘り候補座標から削除

            var dirIndex = rnd.Next(directions.Count);            // 掘り進められる場合はランダムに方向を決めて掘り進める
                                                                  // 決まった方向に先2マス分を通路とする
            switch (directions[dirIndex])
            {
                case Direction.Up:
                    Debug.Log("UPやないかい");
                    y -= 1;
                    SetPath(x, y);
                    y -= 1;
                    SetPath(x, y);
                    break;
                case Direction.Right:
                    x += 1;
                    SetPath(x, y);
                    x += 1;
                    SetPath(x, y);
                    break;
                case Direction.Down:
                    y += 1;
                    SetPath(x, y);
                    y += 1;
                    SetPath(x, y);
                    break;
                case Direction.Left:
                    x -= 1;
                    SetPath(x, y);
                    x -= 1;
                    SetPath(x, y);
                    break;
            }
            break;
        }
        Debug.Log("ee");

        // どこにも掘り進められない場合、穴掘り開始候補座標から掘りなおし
        // 候補座標が存在しないとき、穴掘り完了
        var cell = GetStartCell();
        if (cell != null)
        {
            Dig(cell.X, cell.Y);
        }
        GameObject obj = (GameObject)Resources.Load("WallCube");
        Debug.Log("あれ");
        Debug.Log(Width);
        for (int i = 0; i < Height; i++)
        {
            Debug.Log(Maze[i, 6]);
            for (int k = 0; k < Width; k++)
            {

                if (Maze[i, k] == Wall)
                {

                    Instantiate(obj, new Vector3(i * 1.0f, 1.0f, k * 1.0f), Quaternion.identity);
                }

            }
        }
    }

    // 座標を通路とする(穴掘り開始座標候補の場合は保持)
    private void SetPath(int x, int y)
    {
        Debug.Log("呼ばないで");
        Maze[x, y] = Path;
        if (x % 2 == 1 && y % 2 == 1)
        {
            // 穴掘り候補座標
            StartCells.Add(new Cell() { X = x, Y = y });
        }
    }

    // 穴掘り開始位置をランダムに取得する
    private Cell GetStartCell()
    {
        if (StartCells.Count == 0) return null;

        // ランダムに開始座標を取得する
        var rnd = new System.Random();
        var index = rnd.Next(StartCells.Count);
        var cell = StartCells[index];
        StartCells.RemoveAt(index);

        return cell;
    }




    // セル情報
    private class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
*/

}
