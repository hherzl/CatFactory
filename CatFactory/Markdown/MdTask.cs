namespace CatFactory.Markdown
{
    /// <summary>
    /// 
    /// </summary>
    public class MdTask
    {
        /// <summary>
        /// 
        /// </summary>
        public MdTask()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="completed"></param>
        /// <param name="text"></param>
        public MdTask(bool completed, string text)
        {
            Completed = completed;
            Text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Completed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Text { get; set; }
    }
}
