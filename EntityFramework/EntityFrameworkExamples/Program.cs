using EntityFrameworkExamples;

EntityFrameworkDbContext entityFrameworkDbContext = new EntityFrameworkDbContext();

/**********
* Example 1 whith Single Table 
* ****************************
Course course = new Course();
course.Title = "C#";
course.Fees = 8000;
course.IsActive = true;
course.StartDate = new DateTime(2025-4-2);

// Insert Data.
entityFrameworkDbContext.Courses.Add(course);
entityFrameworkDbContext.SaveChanges();

// To Get All Data.
List<Course> courses = entityFrameworkDbContext.Courses.ToList();

// Only Actived courses
List<Course> activeCourses = entityFrameworkDbContext.Courses.Where(x => x.IsActive).ToList();

Course csharpCourse = entityFrameworkDbContext.Courses.Where(x => x.Title.Contains("C#")).FirstOrDefault();

//Edit Data
csharpCourse.Title = "Professional Programming C#";
csharpCourse.Fees = 9000;

entityFrameworkDbContext.SaveChanges();

//Delete Data
entityFrameworkDbContext.Courses.Remove(csharpCourse);
entityFrameworkDbContext.SaveChanges();

***********************/

Course course = new Course();
course.Title = "laravel";
course.Fees = 10000;
course.IsActive = true;
course.StartDate = DateTime.Now;

Topic topic1 = new Topic();
topic1.Name = "Getting Started";
topic1.Duration = 120;

Topic topic2 = new Topic();
topic2.Name = "Basic Syntax";
topic2.Duration = 100;

course.Topics = new List<Topic>();
course.Topics.Add(topic1);
course.Topics.Add(topic2);

entityFrameworkDbContext.Courses.Add(course);
entityFrameworkDbContext.SaveChanges();