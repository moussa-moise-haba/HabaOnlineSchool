
using System.Collections.Generic;

namespace HabaOnlineSchool.Model
{
    public class Author 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IList<Course> Courses { get; set; }



    }
}
