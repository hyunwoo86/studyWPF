using System.Windows.Controls;

namespace studyGN.Commons
{
    public abstract class InitializableUserControl : UserControl
    {
        /// <summary>
        /// Main 되는 UserControl을 관리하기 위한 상위 Class
        /// </summary>
        public virtual void Initialize()
        {
            // 1. Login
        }
    }
}
