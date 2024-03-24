namespace tpmodul6_1302223019
{

    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random random = new Random();
            this.id = random.Next(10000, 100000);
            this.title = title;
            this.playCount = 0;
        }
        public void IncreasePlayCount(int playCount)
        {
            this.playCount = this.playCount + playCount;
        }
        public void PrintVideoDetail()
        {
            Console.WriteLine("Informasi Video");
            Console.WriteLine("ID         : " + this.id);
            Console.WriteLine("Title      : " + this.title);
            Console.WriteLine("Play Count : " + this.playCount);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - PURI LALITA ANAGATA");
            video.IncreasePlayCount(1234567890);
            video.PrintVideoDetail();

        }
    }
}
