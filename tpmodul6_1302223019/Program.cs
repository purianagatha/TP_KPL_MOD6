using System.Diagnostics;

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
            Debug.Assert(title.Length <= 100 && title != null, "title tidak dapat dimasukkan");
            this.title = checked(title);
            this.playCount = 0;
        }
        public void IncreasePlayCount(int playCount)
        {
            Debug.Assert(playCount < 10000000, "play count tidak dapat ditambahkan karena lebih dari 10.000.000");
            Debug.Assert(this.playCount + playCount < int.MaxValue, "jumlah play count melebihi batas");
            this.playCount = checked(this.playCount + playCount);
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
            // video.IncreasePlayCount(1234567890);
            while (true)
            {
                video.IncreasePlayCount(1234567);
            }
            video.PrintVideoDetail();

        }
    }
}
