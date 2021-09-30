using System;

public class TATACar{
DiCorEngine _diCor;
public TATACar(){

_diCor=new DiCorEngine();
}

public void Drive(){

_diCor.Start();
}
public void Halt(){

_diCor.Stop();
}
}
public class DiCorEngine{

public void Start(){}
public void Stop(){}
}
public class VeriCorEngine{

}
public class MultiJetEngine{

}
public class RevorTron{ }
//BS IV 
//BS VI

public class Program
{
public static void Main()
{
TATACar _harrier=new TATACar();
TATACar _nexon=new TATACar();
TATACar _hexa=new TATACar(); 
}
}
