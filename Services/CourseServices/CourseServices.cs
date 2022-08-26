using Domain.Models;
namespace Services.CourseServices;
public class CourseServices
{
    

    private List<Course> cources = new List<Course>();
    public List<Course> GetStudent()
    {
        return cources;
    }
    public void Add(Course cource)
    {
       cources.Add(cource);
    }
    public void Update(Course cource, int id)
    {
        int cnt = 0;
        foreach (var item in cources)
        {
            if (item.Id == id)
            {
               cources.Remove(item);
               cources.Insert(cnt, cource);
            }
            cnt++;
        }

    }
    public Course GetStudentById(int id)
    {
        Course id1 = new Course();
        foreach (var item in cources)
        {
            if (item.Id == id)
                id1 = item;
        }
        return id1;
    }
   public void Delete(int id)
    {
        foreach (var item in cources)
        {
            if (item.Id == id)
            {
                cources.Remove(item);
            }
        }
    }
    public int Count()
    {
        int cnt = cources.Count();
        return cnt;
    }
}