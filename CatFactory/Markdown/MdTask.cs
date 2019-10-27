namespace CatFactory.Markdown
{
    /// <summary>
    /// Represents a task for markdown language
    /// </summary>
    /// <remarks>For more info: https://en.wikipedia.org/wiki/Markdown</remarks>
    public class MdTask
    {
        /// <summary>
        /// Initializes a new instance of <see cref="MdTask"/> class
        /// </summary>
        public MdTask()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="MdTask"/> class
        /// </summary>
        /// <param name="completed">The flag to indicates if task is completed</param>
        /// <param name="text">The text for task</param>
        public MdTask(bool completed, string text)
        {
            Completed = completed;
            Text = text;
        }

        /// <summary>
        /// Indicates if current task is completed
        /// </summary>
        public bool Completed { get; set; }

        /// <summary>
        /// Gets or sets the text for current task
        /// </summary>
        public string Text { get; set; }
    }
}
