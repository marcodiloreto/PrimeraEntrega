using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeraEntrega.ffmpeg
{
    static class Ffmpeg
    {
        
        private static ProcessStartInfo cmd;

        private static void cmdQuery(String comando) {
            //ni idea que hace esto :P
            cmd = new ProcessStartInfo("CMD.exe", "/c " + comando);
            cmd.WorkingDirectory = "C:\\ffmpeg\\bin";
            cmd.CreateNoWindow = true;
            cmd.WindowStyle = ProcessWindowStyle.Hidden;
            
            /*Process p = */Process.Start(cmd);
            /*var reader = p.StandardOutput;
            string line;

            do{

                if (p.StandardOutput.EndOfStream)
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }

            } while (!p.StandardOutput.EndOfStream);*/
            //esto de arriba es para leer el output del proceso (si es que hace falta en algun momento de esta vida cruel y fria)

        }

        public static void extraerAudio(String ruta, String nombre) {

            String arcSinExtension = getArchivoSinExtension(nombre);
            String rutaSinArchivo = extraerArchivoDeRuta(ruta);
            cmdQuery("ffmpeg -i " + ruta + " -ab 192K -ac 2 -ar 44.1K -vn " +rutaSinArchivo+arcSinExtension + "SoloAudio.mp3");
            
        }

        public static void quitarAudio(String ruta, String nombre) {
            String arcSinExtension = getArchivoSinExtension(nombre);
            String extension = nombre.Split('.')[1];
            String rutaSinArchivo = extraerArchivoDeRuta(ruta);
            cmdQuery("ffmpeg -i "+ruta+ " -vcodec copy -an " + rutaSinArchivo+arcSinExtension + "SinAudio."+ extension);
        }

        public static void cambiarFormato(String ruta, String nombre, String formato) {
            String arcSinExtension = getArchivoSinExtension(nombre);
            String rutaSinArchivo = extraerArchivoDeRuta(ruta);
            cmdQuery("ffmpeg -i " + ruta + " " + rutaSinArchivo + arcSinExtension + formato);
        }
        public static void extraerImagenes(String ruta,String archivo,String cant) {
            String arcSinExtension = getArchivoSinExtension(archivo);
            String rutaSinArchivo = extraerArchivoDeRuta(ruta);
            cmdQuery("mkdir " + rutaSinArchivo + arcSinExtension);
            cmdQuery("ffmpeg -i " + ruta + " -r " + cant + " -q:v 2 " + rutaSinArchivo + arcSinExtension + "/img%04d.jpg");
        }

        public static void cambiarResolucion(String ruta, String archivo, String x, String y) {
            String arcSinExtension = getArchivoSinExtension(archivo);
            String extension = archivo.Split('.')[1];
            String rutaSinArchivo = extraerArchivoDeRuta(ruta);
            cmdQuery("ffmpeg -i "+ruta+" -s "+x+"x"+y+" -c:a copy "+rutaSinArchivo+arcSinExtension+x+"x"+y+extension);
        }
        private static String extraerArchivoDeRuta(String ruta) {
            String rutaSinArchivo = "";
            int i=0;
            
            while (i < ruta.Split('\\').Length-1) {
            rutaSinArchivo += ruta.Split('\\')[i] +"\\";
                i++;
            }
            return rutaSinArchivo;
        }

        private static String getArchivoSinExtension(String archivo) { 
        return archivo.Split('.')[0];
        }
    }
}
