using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCollect
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
            => Action(args);

        public static async void Action(string[] args)
        {
            Console.WriteLine("Project Collect Util");
            Console.WriteLine("Version 0.2");
            Console.WriteLine("====================");
            if (args.Length != 1)
            {
                Application.Run(new StartUp());
                return;
            }

            Console.WriteLine("Input Project Type: ");
            string type = Console.ReadLine();
            switch (type)
            {
                case "C#":
                    await CountProject(args[0]);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("====================");
                    Console.WriteLine("Project Lines {0}", len);
                    Console.WriteLine("Project Class {0}", count);
                    Console.ReadKey();
                    return;
                case "Java":
                    await CountProjectJava(args[0]);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("==================================");
                    Console.WriteLine("Project Lines                  {0}", len);
                    Console.WriteLine("Project Class                  {0}", count);
                    Console.WriteLine("Project Imports                {0}", icount);
                    Console.WriteLine("Project Exception Using        {0}", ecount);
                    Console.WriteLine("Project Times Create Instance  {0}", ncount);
                    Console.WriteLine("Project TryCatch Using         {0}", tcount);
                    Console.ReadKey();
                    return;
            }
            return;
        }

        public static async Task CountProject(string dir)
        {
            DirectoryInfo info = new DirectoryInfo(dir);
            foreach(var f in info.GetFiles())
            {
                if(f.Name.EndsWith(".cs"))
                {
                    var lins = File.ReadAllLines(f.FullName);
                    foreach (var line in lins)
                        if (line.Contains("class"))
                            count++;
                    len += lins.Length;
                    GC.SuppressFinalize(lins);
                }
            }
            foreach (var d in info.GetDirectories())
                await CountProject(d.FullName);
            GC.Collect();
        }

        public static async Task CountProjectJava(string dir)
        {
            DirectoryInfo info = new DirectoryInfo(dir);
            foreach(var f in info.GetFiles())
            {
                if(f.Name.EndsWith(".java"))
                {
                    var lins = File.ReadAllLines(f.FullName);
                    foreach (var line in lins) {
                        if (line.Contains("class"))
                            count++;
                        if (line.Contains("import"))
                            icount++;
                        if (line.Contains("try"))
                            tcount++;
                        if (line.Contains("Exception"))
                            ecount++;
                        if (line.Contains("new"))
                            ncount++;
                    }
                    len += lins.Length;
                    GC.SuppressFinalize(lins);
                }
            }
            foreach (var d in info.GetDirectories())
                await CountProjectJava(d.FullName);
            GC.Collect();
        }

        public static int len = 0;
        public static int count = 0;
        public static int icount = 0;
        public static int tcount = 0;
        public static int ecount = 0;
        public static int ncount = 0;
    }
}
