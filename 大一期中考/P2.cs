namespace P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入x的位置:"); //輸出輸入x位置提示
            string str1 = Console.ReadLine(); //使用者輸入位置字串
            int a = Convert.ToInt32(str1); //將字串str1指定給整數資料型別a變數初值

            Console.WriteLine("輸入y的位置:");//輸出輸入x位置提示
            string str2 = Console.ReadLine();//使用者輸入位置字串
            int b = Convert.ToInt32(str2);//將字串str1指定給整數資料型別a變數初值

            Console.WriteLine("輸入z的位置:");//輸出輸入x位置提示
            string str3 = Console.ReadLine();//使用者輸入位置字串
            int c = Convert.ToInt32(str3);//將字串str1指定給整數資料型別a變數初值

            Console.WriteLine("誰先到: 1是人1、2是人2、0是同時到。"); //輸出誰先到提示
            int d = FindClosest(a, b, c); //呼叫FindClosest函數並帶入引數a, b, c 傳回結果指定給整數資料型別d變數初值
            Console.WriteLine(d); //輸出答案
        }

        //解題思路
        // x與y同速度走向z
        // x與y 跟z的距離越長者，越晚到
        //分析函數 傳回值int 帶入形式參數int x, int y, int z
        static int FindClosest(int x, int y, int z)
        {
            //1.輸入
            int dx = x - z; //取出x到z的距離指定給變數dx初值
            int dy = y - z; //取出y到z的距離指定給變數dy初值

            //2.處理
            if (dx < 0) dx = -dx; //如果dx為負，加負號轉正，距離沒有負
            if (dy < 0) dy = -dy;//如果dy為負，加負號轉正，距離沒有負

            //3.輸出

            if (dx < dy) //如過dx小於dy，表示圖速度下人1先到
            {
                return 1; //輸出1
            }
            else if (dx > dy) //如過dx大於dy，表示圖速度下人2先到
            {
                return 2; //輸出2
            }
            else //dx與dy沒有大於或小於就是等於，兩人距離相等，同時到
            {
                return 0; //輸出0
            }
        }
        //結束簽名TMChouys 15分鐘
    }
}