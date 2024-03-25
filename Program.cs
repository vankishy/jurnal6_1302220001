class Program
{
    static void Main()
    {
        SayaTubeUser user = null;

        Console.Write($"Hi! visitor, silahkan masukkan username anda : ");
       string Username = Console.ReadLine();
        user = new SayaTubeUser(Username);

        Console.WriteLine($"Hi! {user.Username}, silahkan data video anda : ");
        string[] judul = ["tes1", "tes2", "tes3", "tes4", "tes5", "tes6", "tes7", "tes8", "tes9", "tes10",];

        for (int i = 0; i < judul.Length; i++)
        {
            user.AddVideo(new SayaTubeVideo(judul[i]));
        }
        user.PrintAllVideoPlaycount();
    }
}
