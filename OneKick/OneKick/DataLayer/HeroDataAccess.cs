using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OneKick.BusinessLogicLayer;

namespace OneKick.DataLayer
{
    public class HeroDataAccess
    {
        private readonly string filePath = "heroes.txt";

        public void SaveHero(Hero hero)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine($"{hero.HeroID}, {hero.Name}, {hero.Age}, {hero.Superpower}, {hero.ExamScore}, {hero.Rank}, {hero.ThreatLevel}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error saving hero: " + ex.Message);
            }
        }
        public List<Hero> LoadHeroes()
        {
            List<Hero> list = new List<Hero>();

            try
            {
                if (!File.Exists(filePath))
                    return list;

                foreach(var line in File.ReadAllLines(filePath))
                {
                    var data = line.Split(',');

                    if (data.Length == 7)
                    {
                        list.Add(new Hero
                        {
                            HeroID = data[0],
                            Name = data[1],
                            Age = int.Parse(data[2]),
                            Superpower = data[3],
                            ExamScore = int.Parse(data[4]),
                            Rank = data[5],
                            ThreatLevel = data[6],
                        });
                    }   
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Error loading heroes: " + ex.Message);
            }
            return list;
        }
    }
}
