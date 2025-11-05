namespace P4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入座標1:");  //輸出輸入座標1提示
            string str1 = Console.ReadLine(); //使用者輸入座標1指定給字串資料型別str1

            Console.WriteLine("輸入座標2:"); //輸出輸入座標1提示
            string str2 = Console.ReadLine(); //使用者輸入座標2指定給字串資料型別str2

            Console.WriteLine("兩個座標顏色是否相同?"); //輸出提示座標兩顏色是否相同

            if (CheckTwoChessboards(str1, str2))  //if多選一 呼叫函數CheckTwoChessboards帶入兩個引數座標1與座標2，回傳若為true表示兩個顏色相同
            {
                Console.WriteLine("相同"); //輸出相同
            }
            else //表示CheckTwoChessboards函數回傳false 表示兩個座標顏色不同
            {
                Console.WriteLine("不相同"); //輸出不相同
            }
        }

        //解題思路
        //寫一個SquareIsWhite函數，判斷座標是否為白色
        //再寫一個CheckTwoChessboards函數，讓輸入兩個座標，每個座標呼叫一次SquareIsWhite函數
        //判斷兩邊值是否相同
        //相同輸出true，不同輸出false

        // 分析函數 傳回值bool布林變數 輸入形式變數string coordinate1, string coordinate2
        static bool CheckTwoChessboards(string coordinate1, string coordinate2)
        {
            //SquareIsWhite(coordinate1) 和 SquareIsWhite(coordinate2)結果一樣，回傳 true
            //SquareIsWhite(coordinate1) 和 SquareIsWhite(coordinate2)結果不一樣，回傳 false
            return SquareIsWhite(coordinate1) == SquareIsWhite(coordinate2);
        }

        // 分析函數 傳回值bool布林變數 輸入形式變數string coordinate
        static bool SquareIsWhite(string coordinate)
        {
            // switch多選一
            switch (coordinate) //判斷帶入的coordinate座標是否為白色
            {
                //將黑色座標都挑出來
                case "a1":
                case "a3":
                case "a5":
                case "a7":

                case "c1":
                case "c3":
                case "c5":
                case "c7":

                case "e1":
                case "e3":
                case "e5":
                case "e7":

                case "g1":
                case "g3":
                case "g5":
                case "g7":

                case "b2":
                case "b4":
                case "b6":
                case "b8":

                case "d2":
                case "d4":
                case "d6":
                case "d8":

                case "f2":
                case "f4":
                case "f6":
                case "f8":

                case "h2":
                case "h4":
                case "h6":
                case "h8":
                    return false; //以上座標都不是白色

                default:
                    return true; //其他都是白色
            }
            //結束簽名TMChouys 35分鐘
        }
    }
}
