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

    static void Main(string[] args)
    {
        var q1 = new Question("En iyi programlama dili hangisidir?", new string[] { "C#", "Python", "Java", "C++" }, "C#");
        var q2 = new Question("En popüler programlama dili hangisidir?", new string[] { "C#", "Python", "Java", "C++" }, "C#");
        var q3 = new Question("En kazandıran programlama dili hangisidir?", new string[] { "C#", "Python", "Java", "C++" }, "C#");

        var questions = new Question[] { q1, q2, q3 };

        int index = 1;
        foreach (var q in questions)
        {
            Console.WriteLine($"soru {index}: {q.Text}");
            index++;

            foreach (var c in q.Choices)
            {
                Console.WriteLine($"-{c}");
            }

            Console.Write("cevap: ");
            var cevap = Console.ReadLine();
            Console.WriteLine(q.checkAnswer(cevap));
        }
    }
}