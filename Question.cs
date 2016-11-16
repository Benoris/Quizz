using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Quizz
{
    class Question
    {
        private string _question;

        public string Question1
        {
            get { return _question; }
            set { _question = value; }
        }

        private string _answer;

        public string Answer
        {
            get { return _answer; }
            set { _answer = value; }
        }

        private string[] _option;

        public string[] Option
        {
            get { return _option; }
            set { _option = value; }
        }

        public Question(string Quest,string Ans,string WrongAnswer1,string WrongAnswer2,string WrongAnswer3)
        {
            this.Question1 = Quest;
            this.Answer = Ans;
            Option = new string[4];
            string[] rep = new string[4];
            Random r = new Random();
            
            rep[0] = Ans;
            rep[1] = WrongAnswer1;
            rep[2] = WrongAnswer2;
            rep[3] = WrongAnswer3;
            int rdm = r.Next(0, 4);
            int cptCases = 0;
            while (cptCases < 4)
            {
                rdm = r.Next(0, 4);
                if (Option[rdm] == null)
                {
                    Option[rdm] = rep[cptCases];
                    cptCases++;
                }
                
            }
        }
        

    }
}
