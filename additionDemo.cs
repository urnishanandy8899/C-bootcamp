public int Add(string number)
{
int sum = 0;
var texts = number.Split(new char[] {'\n', ','});
foreach(var str in texts)
{
int n = 0;
if(int.TryParse(str, out n))
{
sum+=n;
}
}
return sum;
}

