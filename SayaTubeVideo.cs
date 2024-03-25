using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Contract.Requires(title != null && title.Length <= 200, "Judul video memiliki panjang maksimal 200 karakter dan tidak berupa null");

        this.id = RandomNumber();
        this.title = title;
        this.playCount = 0;
    }

    private int RandomNumber()
    {
        Random random = new Random();
        return random.Next(00000, 99999);
    }

    public void IncreasePlayCount(int count)
    {
        Contract.Requires(count > 0 && count <= 25000000, "Input penambahan Play Count 25000000");
        playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID : {id}");
        Console.WriteLine($"Title : {title}");
        Console.WriteLine($"Play Count : {playCount}");
    }

    public string GetTitle()
    {
        return title;
    }

    public int GetPlayCount()
    {
        return playCount;
    }
}
