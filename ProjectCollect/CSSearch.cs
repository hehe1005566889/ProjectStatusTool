using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCollect
{
    class CSSearch
    {
        public CSSearch(string path)
        {
            this.path = path;
            GC.Collect();
        }

        public async Task OnSearch(string path)
        {
            await CountProjectJava(path);
            GC.Collect();
        }

        public async Task CountProjectJava(string dir)
        {
            DirectoryInfo info = new DirectoryInfo(dir);
            foreach (var f in info.GetFiles())
            {
                if (f.Name.EndsWith(".cs"))
                {
                    var lins = File.ReadAllLines(f.FullName);
                    foreach (var line in lins)
                    {
                        if (line.Contains("class ") && !line.Contains(".class"))
                            OnFoundClass(line, f.FullName);
                        if (line.Contains("using"))
                            icount++;
                        if (line.Contains("try"))
                            tcount++;
                        if (line.Contains("Exception"))
                            ecount++;
                        if (line.Contains("new"))
                            ncount++;
                        if (line.Contains("interface "))
                            OnFoundInterface(line, f.FullName);
                        if (line.Contains("enum "))
                            OnFoundEnum(line, f.FullName);
                        if (line.Contains("Attribute"))
                            OnFoundAnnotation(line, f.FullName);
                        if (line.Contains("struct "))
                            OnFoundRecord(line, f.FullName);
                    }
                    len += lins.Length;
                    GC.SuppressFinalize(lins);
                }
            }
            foreach (var d in info.GetDirectories())
                await CountProjectJava(d.FullName);
            GC.Collect();
        }

        private void OnFoundClass(string line, string file)
        {
            count++;
            int index = line.IndexOf("class") + 6;
            line = line.Remove(0, index);
            if (line.Contains(" "))
                line = line.Remove(line.IndexOf(" ") + 1);
            ClassNamse.Add(line);
            ClassNamseFile.Add(file);
        }

        private void OnFoundInterface(string line, string file)
        {
            itecount++;
            int index = line.IndexOf("interface") + 10;
            line = line.Remove(0, index);
            if (line.Contains(" "))
                line = line.Remove(line.IndexOf(" ") + 1);
            InterfaceNamse.Add(line);
            InterfaceNamseFile.Add(file);
        }

        private void OnFoundEnum(string line, string file)
        {
            enucount++;
            int index = line.IndexOf("enum") + 5;
            line = line.Remove(0, index);
            if (line.Contains(" "))
                line = line.Remove(line.IndexOf(" ") + 1);
            EnumNamse.Add(line);
            EnumNamseFile.Add(file);
        }

        private void OnFoundRecord(string line, string file)
        {
            rcocount++;
            int index = line.IndexOf("struct") + 7;
            line = line.Remove(0, index);
            if (line.Contains(" "))
                line = line.Remove(line.IndexOf(" ") + 1);
            RecoedNamse.Add(line);
            RecoedNamseFile.Add(file);
        }

        private void OnFoundAnnotation(string line, string file)
        {
            anocount++;
        }

        private readonly string path;
        public int len = 0;
        public int count = 0;
        public int itecount = 0;
        public int enucount = 0;
        public int anocount = 0;
        public int rcocount = 0;
        public int icount = 0;
        public int tcount = 0;
        public int ecount = 0;
        public int ncount = 0;

        public readonly List<string> ClassNamse = new List<string>();
        public readonly List<string> InterfaceNamse = new List<string>();
        public readonly List<string> EnumNamse = new List<string>();
        public readonly List<string> RecoedNamse = new List<string>();

        public readonly List<string> ClassNamseFile = new List<string>();
        public readonly List<string> InterfaceNamseFile = new List<string>();
        public readonly List<string> EnumNamseFile = new List<string>();
        public readonly List<string> RecoedNamseFile = new List<string>();
    }
}
