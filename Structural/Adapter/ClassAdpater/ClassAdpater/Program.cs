using System;

//Analyiticstool Interface - Adaptee

interface InterfaceTool
{
   public void AnalyzeData();
}

//class JsonTool

class JsonAnalyticsTool : InterfaceTool
{
    private string JsonData;

    public void SetData(string JsonData)
    {
        this.JsonData = JsonData;
    }
    public void AnalyzeData()
    {
        if (JsonData.Contains("json"))
            Console.WriteLine("Cannot Analyze the Data. Incorrect Format");
        else
            Console.WriteLine("Analyzed data for: " + JsonData);
    }
}

//Adapter interface

interface Adapter
{
    public void ConvertData(string data);
}

//Concrete adapter

class ConcreteAdapater : Adapter , InterfaceTool  //Is-a relationship with Adaptee(InterfaceTool)
{
    string newdata;
    public void ConvertData(String XmlData)
    {
        newdata = XmlData + "json";
    }

    public void AnalyzeData()
    {

    }



}