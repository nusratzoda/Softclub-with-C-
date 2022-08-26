using Domain.Models;
namespace Services.TeacherServices;
public class TeacherServices
{
    private List<Teacher> teachers = new List<Teacher>();
    public List<Teacher> GetStudent()
    {
        return teachers;
    }
    public void Add(Teacher teacher)
    {
        teachers.Add(teacher);
    }
    public void Update(Teacher teacher, int id)
    {
        int cnt = 0;
        foreach (var item in teachers)
        {
            if (item.Id == id)
            {
               teachers.Remove(item);
                teachers.Insert(cnt, teacher);
            }
            cnt++;
        }

    }
    public Teacher GetStudentById(int id)
    {
        Teacher id1 = new Teacher();
        foreach (var item in teachers)
        {
            if (item.Id == id)
                id1 = item;
        }
        return id1;
    }
   public void Delete(int id)
    {
        foreach (var st in teachers)
        {
            if (st.Id == id)
            {
                teachers.Remove(st);
            }
        }
    }
    public int Count()
    {
        int cnt = teachers.Count();
        return cnt;
    }
}