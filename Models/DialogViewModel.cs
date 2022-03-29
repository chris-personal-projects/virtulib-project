using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtulib_project.Models
{
    public class DialogViewModel : ObservableObject
    {
        private bool m_isShow;
        private object m_dialogObject;

        public bool IsShow
        {
            get { return m_isShow; }
            set { m_isShow = value; OnPropertyChanged(); }
        }

        public object DialogObject
        {
            get { return m_dialogObject; }
            set
            {
                if (m_dialogObject == value) return;
                m_dialogObject = value; OnPropertyChanged();
            }
        }

    }
}
