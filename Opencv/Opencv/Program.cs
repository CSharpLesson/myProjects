using OpenCvSharp;
using System;
using System.IO;
using DlibDotNet;

namespace Opencv
{
    class Program
    {
        private const string inputFilePath = "1.jpg";
        static void Main(string[] args)
        {
            using (var fd = Dlib.GetFrontalFaceDetector())
            {
                var img = Dlib.LoadImage<RgbPixel>(inputFilePath);

                // find all faces in the image
                var faces = fd.Operator(img);
                foreach (var face in faces)
                {
                    // draw a rectangle for each face
                    Dlib.DrawRectangle(img, face, color: new RgbPixel(0, 255, 255), thickness: 4);
                    
                }
                Dlib.SaveJpeg(img, "1.jpg");
            }
        }
        //static void Process(string videoPath)
        //{
        //    Console.WriteLine($"[VideoProcessor] Processing videoPath {videoPath}");
        //    Console.WriteLine("[VideoProcessor] " + (File.Exists(videoPath) ? "Video exists" : "Video does not exist"));

        //    VideoCapture capture = new VideoCapture(videoPath);

        //    // using (Window window = new Window("capture"))
        //    using (Mat image = new Mat()) // Frame image buffer
        //    {
        //        var frameIndex = 0;

        //        // Loop while we can read an image (aka: image.Empty is not true)
        //        do
        //        {
        //            // Read the next
        //            capture.Read(image);

        //            // We only want to save every FPS hit since we have 1 image per second -> mod
        //            if (frameIndex % capture.Fps == 0)
        //            {
        //                var saveResult = image.SaveImage($"image_{frameIndex}.png");
        //                Console.WriteLine($"[VideoProcessor] Saved image #{frameIndex}");
        //            }

        //            frameIndex++;
        //        } while (!image.Empty());
        //    }

        //    Console.WriteLine($"[VideoProcessor] Done Processing");
        //}
    }
}
