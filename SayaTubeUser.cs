using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using System.Diagnostics;

public class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public string Username;

    public SayaTubeUser(string username)
    {
        Contract.Requires(username != null && username.Length <= 100, "Nama username memiliki panjang maksimal 100 karakter dan tidak berupa null");

        this.Username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public int GetTotalVideoPlayCount()
    {
        return uploadedVideos.Count;
    }

    public void AddVideo(SayaTubeVideo mVideo)
    {
        Debug.Assert(mVideo != null && mVideo.GetPlayCount() < int.MaxValue, "Play count out of range");
       this.uploadedVideos.Add(mVideo);
    }

    public void PrintAllVideoPlaycount()
    {
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            Console.WriteLine($"User : {Username}");
            Console.WriteLine($"Video {i + 1} judul : {this.uploadedVideos[i].GetTitle()}");
        }
    }
}
