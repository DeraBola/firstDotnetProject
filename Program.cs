string pangram = "The quick brown fox jumps over the lazy dog";
char[] valueArray = pangram.ToCharArray();
Array.Reverse(valueArray);
string result = new(valueArray);

string[] message = result.Split();

// Console.WriteLine(message);

// foreach(string items in message){
//     Console.WriteLine(items);
// }

for(int i = message.Length -1; i >= 0; i--){
    // Console.WriteLine(message[i]);
    Console.Write(message[i] + " ");
}
