using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneKick.BusinessLogicLayer
{
    public class Hero
    {
        public string HeroID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Superpower { get; set; }
        public int ExamScore { get; set; }
        public string Rank { get; set; } 
        public string ThreatLevel { get; set; }

        //this will automatically cal the rank and threat based on score
        public void CalRankandThreat()
        {
            
        }
    }
}