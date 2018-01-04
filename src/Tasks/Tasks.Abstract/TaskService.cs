namespace Tasks.Abstract
{
    public abstract class TaskService : ITaskService
    {
        public abstract void Run();

        public virtual void LoadData()
        {

        }

        public virtual void SaveDate()
        {

        }
    }
}
