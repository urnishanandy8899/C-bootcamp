using System;
using System.Threading.Tasks;
namespace UIEventApp
{
public class SearchWindow
{
Button clearButton = new Button();
TextBox searchBox = new TextBox();
public SearchWindow()
{
Action action = new Action(this.ClearButton_Clicked);
this.clearButton.Click += action;
}
public void SimulateClearButtonClick()
{
clearButton.OnClick();
}
private void ClearButton_Clicked()
{
searchBox.Clear();
}
}
public class Button
{
//Event Click
public event Action Click;
public void OnClick()
{
Click?.Invoke();
}
}
public class TextBox
{
public void Clear()
{
Console.WriteLine("TextBox Content Cleared");
}
}
public class Program
{
public static void Main(string[] args)
{
SearchWindow searchWindow = new SearchWindow();
while (true)
{
Console.WriteLine("Press Any Key To Click Clear Button");
Console.Read();
Task.Delay(3000).Wait();
searchWindow.SimulateClearButtonClick();
}
}
}
}
