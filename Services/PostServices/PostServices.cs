using Domain.Models;
namespace Services.PostServices;
public class PostServices
{
    private List<Post> posts = new List<Post>();
    public List<Post> GetStudent()
    {
        return posts;
    }
    public void Add(Post cource)
    {
       posts.Add(cource);
    }
    public void Update(Post post, int id)
    {
        int cnt = 0;
        foreach (var item in posts)
        {
            if (item.Id == id)
            {
               posts.Remove(item);
              posts.Insert(cnt, post);
            }
            cnt++;
        }

    }
    public Post GetStudentById(int id)
    {
        Post id1 = new Post();
        foreach (var item in posts)
        {
            if (item.Id == id)
                id1 = item;
        }
        return id1;
    }
   public void Delete(int id)
    {
        foreach (var item in posts)
        {
            if (item.Id == id)
            {
                posts.Remove(item);
            }
        }
    }
    public int Count()
    {
        int cnt = posts.Count();
        return cnt;
    }
}