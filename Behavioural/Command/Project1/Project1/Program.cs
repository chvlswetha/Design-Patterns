using System;

interface command
{
    public void execute();
}

//concrete commands - DocOpen and DocSave 
class DocOpen : command
{
    Document doc; //command has receiver

    public DocOpen(Document doc)
    {
        this.doc = doc;
    }
    public void execute()
    {
        doc.open();
    }
}
class DocSave : command
{
    Document doc;

    public DocSave(Document doc)
    {
       this.doc = doc;
    }
    public void execute()
    {
        doc.save();
    }
}

//Receiver - Actually perfroming the action Open and Save
class Document
{

    public void open()
    {
        Console.WriteLine("Document Opened");
    }
    public void save()
    {
        Console.WriteLine("Document Saved");
    }
}

//Invoker has command
class menuoptions
{
    command actionopen;
    command actionsave;

    public menuoptions(command actionopen, command actionsave)
    {
        this.actionopen = actionopen;
        this.actionsave = actionsave;
    }

    public void clickopen()
    {
        actionopen.execute();
    }
    public void clicksave()
    {
        actionsave.execute();
    }
}
class main_client
{
    public static void Main(string[] args)
    {
        Document doc = new Document(); //Receiver - perfroming action

        //created concrete commands 
        //sent reciver in the command - where to do action
        command docopen = new DocOpen(doc);  
        command docsave = new DocSave(doc);

        //Invoker - calls methods execute that are from command
        menuoptions menu = new menuoptions(docopen, docsave);

        menu.clickopen();
        menu.clicksave();
    }                   
}