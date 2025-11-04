namespace P3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入石頭數，系統會預估你先手是否會贏："); //輸出輸入提示
            string str1 = Console.ReadLine(); //使用者輸入字串指定給字串資料型別str1變數初值
            int a = Convert.ToInt32(str1); //轉換str1字串資料型別為整數資料型別指定給變數a初值
            Console.WriteLine((CanWinNim(a)) ? "會贏" : "會輸"); //呼叫CanWinNim函數，依照回傳值true顯示會贏，false顯示會輸。
        }

        // 解題思路：
        // 想贏就要讓對手陷入必輸狀態。
        // 拿石頭遊戲中，只要剩下 4 的倍數顆，就一定會輸。
        // 因為不論拿 1、2、3 顆，對手總能湊成下一個 4 的倍數。
        // 所以，開局時只要石頭數不是 4 的倍數，我就能控制節奏，最後讓對手拿最後一顆。



        //分析函數 傳回值 bool 先手會贏給true, 會輸給false，形式參數int n 石頭數
        static bool CanWinNim(int n)
        {
            //輸入
            //int n 石頭數

            //處理
            int r = 0; //宣告整數資料型別r初值為0暫存餘數
            r = n % 4; //將石頭數取餘數4指定給r

            //輸出
            return (r % 4 == 0) ? false : true; //判斷r是否等於0，等於0表示石頭是4的倍數，輸出先手會輸，不等於0表示不為4的倍數，輸出true表示先手會贏。
        }
        //結束簽名TMChouys 20分鐘
    }
}