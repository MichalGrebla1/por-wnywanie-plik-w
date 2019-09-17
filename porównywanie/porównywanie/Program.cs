using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Timers;

namespace porównywanie
{
    class Program
    {
        private static System.Timers.Timer aTimer;



        static void Main(string[] args)
        
        {
              
        
            
            SetTimer();

            string urlString = @"C:\Users\micha\source\repos\porównywanie\porównywanie\url.txt";
            string pageString = @"C: \Users\micha\source\repos\porównywanie\porównywanie\page.txt";

            if (File.Exists(@"C:\Users\micha\source\repos\porównywanie\porównywanie\page.txt"))
            {
                string urlPath = File.ReadAllText(@"C:\Users\micha\source\repos\porównywanie\porównywanie\url.txt", Encoding.UTF8);

                string pagePath = File.ReadAllText(@"C:\Users\micha\source\repos\porównywanie\porównywanie\page.txt", Encoding.UTF8);
                if (urlPath == pagePath)
                {

                }
                else
                {

                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    player.SoundLocation = @"C:\Users\micha\source\repos\porównywanie\porównywanie\x.wav";
                    player.Play();

                }

            }
            else
            {   
                string pathString2 = @"C: \Users\micha\source\repos\porównywanie\porównywanie";
                string fileName = "page.txt";
                pathString2 = System.IO.Path.Combine(pathString2, fileName);
                System.IO.File.Create(pathString2);
                File.Copy(urlString, pageString);


            }
            Console.ReadLine();

        }

        private static void SetTimer()
        {
            
            aTimer = new System.Timers.Timer(300000);
          
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;

        }
        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Ponowne sprawdzanie",
                          e.SignalTime);
            string urlString = @"C:\Users\micha\source\repos\porównywanie\porównywanie\url.txt";
            string pageString = @"C: \Users\micha\source\repos\porównywanie\porównywanie\page.txt";

            if (File.Exists(@"C:\Users\micha\source\repos\porównywanie\porównywanie\page.txt"))
            {
                string urlPath = File.ReadAllText(@"C:\Users\micha\source\repos\porównywanie\porównywanie\url.txt", Encoding.UTF8);
                 string pagePath = File.ReadAllText(@"C:\Users\micha\source\repos\porównywanie\porównywanie\page.txt", Encoding.UTF8);

                if (urlPath == pagePath)
                {

                }
                else
                {

                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    player.SoundLocation = @"C:\Users\micha\source\repos\porównywanie\porównywanie\x.wav";
                    player.Play();

                }

            }
            else
            {
                File.Copy(urlString, pageString);


            }


            Console.ReadLine();
           
        }
        
        }

    }

