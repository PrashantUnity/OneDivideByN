var ls = new List<string>();
int Divisor = 1;
int Dividend = 1;
int DecimalLimit = 300;
while(++Divisor<=1000)
{
    var (D, F) = Divider.Divide(Dividend, Divisor, DecimalLimit);
    ls.Add(string.Concat(F));
} 
var path = @"C:\Users\91746\Desktop\OnDivideByN\Result.txt";
File.WriteAllLines(path,ls);

var ansLs = new List<string>();
foreach( var text in ls)
{
    ansLs.Add(Divider.FindLongestRepeatingSubstring(text)); 
}
var pathTwo = @"C:\Users\91746\Desktop\OnDivideByN\OneDivideByN\Answer.txt";
File.WriteAllLines(pathTwo,ansLs);