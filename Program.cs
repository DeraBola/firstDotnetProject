 Random random = new();
int daysUntilExpiration = random.Next(12);
int discountPercentage;

if(daysUntilExpiration <= 10) {
    Console.WriteLine("Your subscription will expire soon. Renew now!");
    discountPercentage = 10;
}
else if(daysUntilExpiration <= 5) {
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    Console.WriteLine("Renew now and save 10 %!");
}
else if(daysUntilExpiration == 1) {
    Console.WriteLine("Your subscription expires within a day!");
}
else if(daysUntilExpiration == 0) {
    Console.WriteLine("Your subscription has expired.");
}