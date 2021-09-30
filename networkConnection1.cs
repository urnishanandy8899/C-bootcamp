using System;

public class ConsoleLogger{
public void WriteLogContent(string content){
Console.WriteLine(content);
}
}
public class NetWorkConnection{
ConsoleLogger _logger=new ConsoleLogger();
public void Open(){

_logger.WriteLogContent(string.Format("NetworkConnection Opened at:{0}",System.DateTime.Now));
}

public void Connect(){
_logger.WriteLogContent(string.Format("NetworkConnection Connected at:{0}",System.DateTime.Now));
}

public void DisConnnect(){

_logger.WriteLogContent(string.Format("NetworkConnection Disconnected at:{0}",System.DateTime.Now));
}
public void Close(){

_logger.WriteLogContent(string.Format("NetworkConnection Closed at:{0}",System.DateTime.Now));
}

}
public class Program

{
public static void Main()
{
NetWorkConnection _connection=new NetWorkConnection();
_connection.Connect();
System.Threading.Tasks.Task.Delay(3000).Wait();
_connection.Open();
System.Threading.Tasks.Task.Delay(3000).Wait();

_connection.Close();
_connection.Open();
System.Threading.Tasks.Task.Delay(3000).Wait();
_connection.DisConnnect();


}
}
