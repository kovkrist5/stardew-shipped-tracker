using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace stardew
{
    class Shipped
    {
        
        public static int counter;
        public bool check=false;
        public  int id;
        public static int nextid;
        public string name;
        
        public Shipped(string line)
        {
            string[] data = line.Split(';');
            if (Convert.ToString(data[0]) == "True")
            {
                check = true;
                counter++;
            }
            this.id = nextid;
            this.name = data[1];

        }
        public static string file = "shipped_collections.csv";
        public static List<Shipped> Read()
        {
            

            StreamReader sr = new StreamReader(file);
            List<Shipped> shippedlist = new List<Shipped>();
            while (!sr.EndOfStream)
            {
                nextid++;
                shippedlist.Add(new Shipped(sr.ReadLine()));
                
            }
            sr.Close();
            
            return shippedlist;
        }
        
        public static void Write(bool check, string name)
        {
            
        }
    }
}
