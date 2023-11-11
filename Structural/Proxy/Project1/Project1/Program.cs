using System;

interface Image
{
    public void display();
}

//Real class

class RealImage : Image
{
    private string filename;

    public RealImage(string filename)
    {
        this.filename = filename;
        loadfromdisk();
    }
    public void loadfromdisk()
    {
        Console.WriteLine("Loading the Image from Disk:" + filename);
    }
    public void display()
    {
        Console.WriteLine("Displaying the Image:" + filename);
    }
}

//proxy class
class ImageProxy : Image
{
    private string filename;
    private RealImage realimage; // proxy class has-a Realclass/Interface

    public ImageProxy(string filename)
    {
        this.filename = filename;
        this.realimage = null;
    }
    public void display()
    { 
        // creating object only when operation is needed - Lazy Initilization
        if (realimage == null)
        {
            realimage = new RealImage(filename); 
        }
        realimage.display();
    }
}
class Main_client
{
    public static void Main(string[] args)
    {
        //creating Image Proxy for hiogh resolution image
        Image proxy = new ImageProxy("hig_res_image.JPG");

        //Dispalying the image.
        proxy.display();    
    }
}