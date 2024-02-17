
namespace BiasysControl.UICommon
{
    public class LeftMenuHandling
    {
        //implement singleton design pattern for this object
        public static LeftMenuHandling instance = null;
        private static readonly object padlock = new object();
        public static LeftMenuHandling Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new LeftMenuHandling();
                    }
                    return instance;
                }
            }
        }



    }
}
