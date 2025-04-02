using EntityFrameworkExamples;

EntityFrameworkDbContext entityFrameworkDbContext = new EntityFrameworkDbContext();

Course course = new Course();
course.Title = "C#";
course.Fees = 8000;
course.IsActive = true;
course.StartDate = new DateTime(2025-4-2);

entityFrameworkDbContext.Courses.Add(course);
entityFrameworkDbContext.SaveChanges();