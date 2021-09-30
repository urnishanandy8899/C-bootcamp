public interface IEngine
{
void Start();
void Stop();
}

public class TATACar{

IEngine engine;

public TATACar(IEngine engine)
{
this.engine = engine;
}
public void Drive()
{
engine.Start();
}

public void Halt()
{
engine.Stop();
}

}

public class DiCorEngine : IEngine
{
public void Start(){Console.WriteLine("DiCorEngine Started");}
public void Stop(){Console.WriteLine("DiCorEngine Stopped");}
}

public class VeriCorEngine : IEngine
{
public void Start(){Console.WriteLine("VeriCorEngine Started");}
public void Stop(){Console.WriteLine("VeriCorEngine Stopped");}
}

public class MultiJetEngine : IEngine
{
public void Start(){Console.WriteLine("MultiJetEngine Started");}
public void Stop(){Console.WriteLine("MultiJetEngine Stopped");}
}
public class RevorTron : IEngine
{ 
public void Start(){Console.WriteLine("RevorTron Started");}
public void Stop(){Console.WriteLine("RevorTron Stopped");}
}
public class Program
{
public static void Main()
{
IEngine engine = new MultiJetEngine();
TATACar _harrier=new TATACar(engine);
Console.WriteLine("For Harrier car :");
_harrier.Drive();
_harrier.Halt();

Console.WriteLine();

engine = new RevorTron();
TATACar _nexon=new TATACar(engine);
Console.WriteLine("For Nexon car :");
_nexon.Drive();
_nexon.Halt();

Console.WriteLine();

engine = new VeriCorEngine();
TATACar _hexa=new TATACar(engine);
Console.WriteLine("For Hexa car :");
_hexa.Drive();
_hexa.Halt();
}
}
