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
            ranks=File.ReadAllLines(Application.StartupPath + @"\Resources\Text\Policeman\Ranks.txt").ToList();
            return ranks;
        }
        public static List<string> GetFirstNames()
        {
            List<string> fNames = new List<string>();
            fNames = File.ReadAllText(Application.StartupPath + @"\Resources\Text\Policeman\FirstNames.txt").Split(new char[] {'\r','\t','\n'},StringSplitOptions.RemoveEmptyEntries).ToList();
            
            return fNames;
        }

        public static Image GetPolicemanImage(int rank)
        {
            Image image;
            string path = Application.StartupPath + @"\Resources\Images\Policeman\" + (rank+1) + @".png";
            if (File.Exists(path))
                image = Image.FromFile(path);
            else
                image = (Image)(new Bitmap(300, 300));
            return image;
        }

        public static List<string> GetLastNames()
        {
            List<string> lNames = new List<string>();
            lNames = File.ReadAllText(Application.StartupPath + @"\Resources\Text\Policeman\LastNames.txt").Split(new char[] { '\r', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList(); ;
            return lNames;
        }

        public static List<string> GetCriminalNames()
        {
            List<string> names = new List<string>();
            names = File.ReadAllText(Application.StartupPath + @"\Resources\Text\Criminal\Names.txt").Split(new char[] { '\r', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList(); ;
            return names;
        }

        public static List<string> GetСomplexity()
        {
            List<string> Complexity = new List<string>();
            Complexity = File.ReadAllText(Application.StartupPath + @"\Resources\Text\Criminal\Сomplexity.txt").Split(new char[] { '\r', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList(); ;
            return Complexity;
        }
        public static Image GetCriminalImage(int number)
        {
            Image image;
            string path = Application.StartupPath + @"\Resources\Images\Criminal\" + (number+1) + @".png";
            if (File.Exists(path))
                image = Image.FromFile(path);
            else
                image = (Image)(new Bitmap(300,300));
            return image;
        }
    }
}
