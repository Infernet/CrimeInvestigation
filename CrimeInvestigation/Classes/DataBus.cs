using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace CrimeInvestigation.Classes
{
    /// <summary>
    /// Статически класс для получения данных из файлов и изображений
    /// </summary>
    static class DataBus
    {
        public static List<string> GetRanks()
        {
            List<string> ranks = new List<string>();
            ranks=File.ReadAllLines(Application.StartupPath + @"Resources\Text\Policeman\Ranks.txt").ToList();
            return ranks;
        }
        public static List<string> GetFirstNames()
        {
            List<string> fNames = new List<string>();
            fNames = File.ReadAllLines(Application.StartupPath + @"Resources\Text\Policeman\FirstNames.txt").ToList();
            return fNames;
        }
        public static List<string> GetLastNames()
        {
            List<string> lNames = new List<string>();
            lNames = File.ReadAllLines(Application.StartupPath + @"Resources\Text\Policeman\LastNames.txt").ToList();
            return lNames;
        }

        public static List<string> GetСomplexity()
        {
            List<string> Complexity = new List<string>();
            Complexity = File.ReadAllLines(Application.StartupPath + @"Resources\Text\Criminal\Сomplexity.txt").ToList();
            return Complexity;
        }
        public static Image GetCriminalImage(int number)
        {
            Image image;
            string path = Application.StartupPath + @"Resources\Images\Criminal\" + number + @".txt";
            if (File.Exists(path))
                image = Image.FromFile(path);
            else
                image = (Image)(new Bitmap(300,300));
            return image;
        }
    }
}
