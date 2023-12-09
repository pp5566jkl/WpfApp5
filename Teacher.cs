using System.Collections.ObjectModel;

namespace WpfApp5
{
    internal class Teacher
    {
        //產生教師姓名以及授課科目清單
        public String TeacherName { get; set; }
        public ObservableCollection<Course> TeachingCourses { get; set; }
        public Teacher()
        {
            TeachingCourses = new ObservableCollection<Course>();
        }

        public override string ToString()
        {
            return $"{TeacherName}";
        }

    }
}
