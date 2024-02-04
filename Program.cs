string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin") & level > 55){
Console.WriteLine("Welcome, Super Admin user.");
}else {
    Console.WriteLine("Welcome, Admin user.");
}
if (permission.Contains("Manager") & level >= 20){
Console.WriteLine("Contact an Admin for access.");
}else {
    Console.WriteLine("You do not have sufficient privileges.");
}