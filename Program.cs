string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderID = orderStream.Split(',');
Array.Sort(orderID);

foreach(var item in orderID){
    if(item.Length == 4){
        
        Console.WriteLine(item);
    }else{
         Console.WriteLine(item + "\t- Error");
    }
}
