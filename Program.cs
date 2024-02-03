Random coinFlip = new();

int headTail = coinFlip.Next(2);

string coinResult = headTail == 0 ? "heads" : "tails";

Console.WriteLine(coinResult);