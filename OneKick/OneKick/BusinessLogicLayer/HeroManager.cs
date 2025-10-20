using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneKick.DataLayer;

namespace OneKick.BusinessLogicLayer
{
    public class HeroManager
    {
        private HeroDataAccess dataAccess = new HeroDataAccess();

        public void AddHero(Hero hero)
        {
            if (string.IsNullOrWhiteSpace(hero.HeroID) ||
                string.IsNullOrWhiteSpace(hero.Name) ||
                string.IsNullOrWhiteSpace(hero.Superpower) ||
                string.IsNullOrWhiteSpace(hero.Rank) ||
                string.IsNullOrWhiteSpace(hero.ThreatLevel))
                throw new System.Exception("All fields must be filled.");

            if (hero.Age <= 0)
                throw new System.Exception("Age must be positive.");

            if (hero.ExamScore <= 0)
                throw new System.Exception("Exam score must be positive");

            dataAccess.SaveHero(hero);
        }

        public List<Hero> GetAllHeroes()
        {
            return dataAccess.LoadHeroes();
        }
    }
}
