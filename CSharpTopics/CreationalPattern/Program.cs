// See https://aka.ms/new-console-template for more information
using CreationalPattern.AbstractFactory;
using CreationalPattern.Builder;

Console.WriteLine("Hello, World!");

ItemBuilder itemBuilder = new ItemBuilder();
itemBuilder.SetValue1("Password");
itemBuilder.SetValue2("Username");

Item item = itemBuilder.GetItem();

CarFactory abstractFactory = new NissanFactory();
Engine engine = abstractFactory.EngineFactory.CreateEngine();
HeadLight headLight = abstractFactory.HeadLightFactory.CreateHeadLight();