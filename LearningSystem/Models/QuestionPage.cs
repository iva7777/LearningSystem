namespace LearningSystem.Models
{
    using System.Collections.Generic;

    public class QuestionPage
    {
        public object Id { get; set; }

        public string QuestionSlug { get; set; }

        public ICollection<Question> Questions { get; set; }
    }
}