
using NestedObjects;

Advisor compSciAdvisor = new Advisor()
{
	Email = "Annemarie@cptc.edu",
	FullName = "Aneemarie Smith",
	OfficeLocation = "B17 Rm 150"
};

Student stu1 = new Student()
{
	FirstName = "Camreon",
	LastName = "White",
	DateOfBirth = new DateOnly(1900, 12, 12),
	StudentAdvisor = compSciAdvisor,
	PhoneNumber = "2533324483",
	SchoolEmail = "csd213@students.cptc.edu"
};

Console.WriteLine($"Student: {stu1.FirstName} has {stu1.StudentAdvisor.FullName} as an advisor");