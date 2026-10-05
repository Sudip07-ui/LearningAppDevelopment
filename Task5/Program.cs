DateTime birthDate = new DateTime(2005, 1, 15);

DateTime currentDate = DateTime.Now;

TimeSpan ageDifference = currentDate - birthDate;

int age = (int)(ageDifference.TotalDays / 365.25);

Console.WriteLine("Birthdate: " + birthDate.ToShortDateString());
Console.WriteLine("Current Date: " + currentDate);
Console.WriteLine("Age: " + age + " years");

DateTime newDate = birthDate.AddDays(10);

Console.WriteLine("Birthdate after 10 days: " + newDate.ToShortDateString());