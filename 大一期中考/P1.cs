namespace P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入到達時間:"); //輸出到達時間提示
            string str1 = Console.ReadLine(); //使用者輸入時間並指定為字串str1初值
            int a = Convert.ToInt32(str1); //資料型別轉換字串轉為整數指定給整數資料型別變數a初值

            Console.WriteLine("輸入延遲時間:");//輸出到延遲間提示
            string str2 = Console.ReadLine(); //使用者輸入時間並指定為字串str2初值
            int b = Convert.ToInt32(str2); //資料型別轉換字串轉為整數指定給整數資料型別變數b初值

            int c = FindDelayedArrivalTime(a, b); //呼叫FindDelayedArrivalTime函數並帶入參數a, b
            Console.WriteLine("火車到達時間:"); //輸出火車到達時間提示
            Console.WriteLine(c + "時"); //輸出火車到達時間c
        }

        // 函數分析 傳回值 int 24進制時間  輸入形式參數int arrivalTime, int delayedTime
        static int FindDelayedArrivalTime(int arrivalTime, int delayedTime)
        {
            //1.輸入
            //int arrivalTime, int delayedTime

            //2.處理
            int time = arrivalTime + delayedTime;

            //3.輸出
            return (time % 24);
        }
        //結束簽名TMChouys  10分鐘寫完
    }
}