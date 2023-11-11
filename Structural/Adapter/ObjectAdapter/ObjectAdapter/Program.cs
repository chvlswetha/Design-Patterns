using System;

//Third party tool- Adapteee - JsonAnalytics

class JsonAnalyticsTool
{
    private string JsonData;

    public void setData(string JsonData)
    {
        this.JsonData = JsonData;
    }
    public void AnalyzeData()
    {
       if(JsonData.Contains("json"))
        {
            Console.WriteLine("Analyzing Json Data :" + JsonData);
        }
       else
        {
            Console.WriteLine("Data not in the Correct format. Please Provide Json Data");
        }
    }
}

//Adapter interface
interface Adapterinterface
{
    public void ConvertData(String XmlData);
}

//ConcreateAdapter - 
class ConcreteAdpater : Adapterinterface
{
    JsonAnalyticsTool jsontool;  //Adaptee is a data Member/Object here.

    public void ConvertData(String XmlData)
    {
        Console.WriteLine("converting XmlData to JSonData for :" + XmlData);
        string newdata = XmlData + " json";

        Console.WriteLine("converted XmlData to JSonData :" + newdata);
        jsontool = new JsonAnalyticsTool();
        jsontool.setData(newdata);
        jsontool.AnalyzeData();
    }
}

//Main_client

class Main_client
{
    public static void Main(string[] args)
    {
        string XmlData = "Sample Data";
        JsonAnalyticsTool jsontool = new JsonAnalyticsTool();
        jsontool.setData(XmlData);
        jsontool.AnalyzeData();

        Console.WriteLine("-----------------------------------------");

        Adapterinterface adapter = new ConcreteAdpater();
        adapter.ConvertData(XmlData);

    }
}