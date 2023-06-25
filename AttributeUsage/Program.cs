using System;
using System.Security.Cryptography.X509Certificates;

//ref link:https://www.youtube.com/watch?v=8Of5dprReJg&list=PLRwVmtr-pp05brRDYXh-OTAIi-9kYcw3r&index=9
//

//[assembly: Me] // Assembly tag attribute

//[AttributeUsage(AttributeTargets.Class)] // restriction attribute to only classes
//[AttributeUsage(AttributeTargets.Class | AttributeTargets.Field)] // combine value to single enum value
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Field, AllowMultiple = true)]
class MeAttribute : Attribute 
{
    public MeAttribute()
    {
        Console.WriteLine("MeAttribute()");
    }
}

[Me] // attribute tag
[Me] // multiple attribute
[Me] // multiple attribute
[Me] // multiple attribute
[Me] // multiple attribute
[Me , Me ,Me ,Me] // multiple attribute
class MeVictim
{
    //[Me]
    //public int MeProperty { [Me] get { return 5; } }
    public int MeProperty { get { return 5; } }
    //[Me]
    public event Action MeEvent;
    [Me]
    public string MeField;
    //[Me]
    //[return: Me] // return tag attribute
    //int MeMethod([Me] int meParameter) { return meParameter; } // parameter tag attribute
    int MeMethod(int meParameter) { return meParameter; }
}

class MainClass
{
    static void Main()
    {
        typeof(MeVictim).GetCustomAttributes(false);
    }
}