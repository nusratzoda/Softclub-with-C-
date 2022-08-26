using Domain.Models;
namespace Services.StudentServices;
public class StudentServices
{
    private List<Student> students = new List<Student>();
    public List<Student> GetStudent()
    {
        return students;
    }
    public void Add(Student student)
    {
        students.Add(student);
    }
    public void Update(Student student, int id)
    {
        int cnt = 0;
        foreach (var item in students)
        {
            if (item.Id == id)
            {
               students.Remove(item);
                students.Insert(cnt, student);
            }
            cnt++;
        }

    }
    public Student GetStudentById(int id)
    {
        Student id1 = new Student();
        foreach (var item in students)
        {
            if (item.Id == id)
                id1 = item;
        }
        return id1;
    }
   public void Delete(int id)
    {
        foreach (var item in students)
        {
            if (item.Id == id)
            {
                students.Remove(item);
            }
        }
    }
    public int Count()
    {
        int cnt = students.Count();
        return cnt;
    }
}