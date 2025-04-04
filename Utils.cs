using System;
using System.Drawing;
using System.IO;
using System.Media;

class Utils
{
    public static void PlayGreeting()
    {
        string full_location = System.AppDomain.CurrentDomain.BaseDirectory;

        string new_path = full_location.Replace("bin\\Debug\\", "");

        try
        {
            string full_path = Path.Combine(new_path, "greeting.wav");

            using (SoundPlayer play = new SoundPlayer(full_path))
            {
                play.PlaySync();
            }
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
        }
    }

    public static void DisplayAsciiArt()
{
        //get the full path
        string path_project = AppDomain.CurrentDomain.BaseDirectory;

        //then replace the bin\\Debug\\
        string new_path_project = path_project.Replace("bin\\Debug\\", "");

        //then combine the project full path and the image name with the //format
        string full_path = Path.Combine(new_path_project, "OIP.jpg");

        //then start working on the logo
        //with the Ascii
        Bitmap image = new Bitmap(full_path);
        image = new Bitmap(image, new Size(120, 120));

        //for loop , for inner and the outer 
        //nested
        for (int height = 0; height < image.Height; height++)
        {
            //then now work on the width
            for (int width = 0; width < image.Width; width++)
            {
                //now let us work on theascii design
                Color pixelColor = image.GetPixel(width, height);
                int color = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;

                //now make use of the color
                char ascii_design = color > 200 ? '.' : color > 150 ? '*' : color > 100 ? '0' : color > 50 ? '#' : '@';
                Console.Write(ascii_design);//output the design
            }//end of the for loop inner
            Console.WriteLine();//skip the line
        }//end of the for loop outer



    }
}
