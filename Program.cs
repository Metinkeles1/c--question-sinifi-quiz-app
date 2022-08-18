class Program
{
    class Question
    {
        public Question(string text, string[] choices, string answer)
        {
            this.Text = text;
            this.Choices = choices;
            this.Answer = answer;
        }
        public string Text { get; set; }
        public string[] Choices { get; set; }
        public string Answer { get; set; }

        public bool checkAnswer(string answer)
        {
            return this.Answer.ToLower() == answer.ToLower();
        }
    }

    class Quiz
    {
        public Quiz(Question[] questions)
        {
            this.Questions = questions;
            this.QuestionIndex = 0;
        }
        private Question[] Questions { get; set; }

        public int QuestionIndex { get; set; }

        public Question GetQuestion()
        {
            return this.Questions[this.QuestionIndex];
        }

        public void DisplayQuestion()
        {
            var question = this.GetQuestion();
            Console.WriteLine($"soru {this.QuestionIndex + 1}: {question.Text}");

            foreach (var c in question.Choices)
            {
                Console.WriteLine($"-{c}");
            }
            Console.Write("cevap: ");
            var cevap = Console.ReadLine();
            this.Guess(cevap);
        }

        public void Guess(string answer)
        {
            var question = this.GetQuestion();
            Console.WriteLine(question.checkAnswer(answer));
            this.QuestionIndex++;

            if (this.Questions.Length == this.QuestionIndex)
            {
                //skor
                return;
            }
            else
            {
                this.DisplayQuestion();
            }

        }
    }

    static void Main(string[] args)
    {
        var q1 = new Question("En iyi programlama dili hangisidir?", new string[] { "C#", "Python", "Java", "C++" }, "C#");
        var q2 = new Question("En popüler programlama dili hangisidir?", new string[] { "C#", "Python", "Java", "C++" }, "C#");
        var q3 = new Question("En kazandıran programlama dili hangisidir?", new string[] { "C#", "Python", "Java", "C++" }, "C#");

        var questions = new Question[] { q1, q2, q3 };
        var quiz = new Quiz(questions);

        quiz.DisplayQuestion();
    }
}