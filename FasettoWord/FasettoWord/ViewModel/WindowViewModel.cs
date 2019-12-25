using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace FasettoWord
{
    class WindowViewModel : BaseViewModel
    {
        #region PrivateMember
        private Window mWindow;
        #endregion

        #region Public Properties
        public int ResizeBorder { get; set; } = 6;

        public Thickness ResizeBorderThickness { get { return new Thickness { ResizeBorder }; } }
        #endregion

        #region Constructor
        public WindowViewModel(Window window)
        {
            mWindow = window;
        }

        #endregion
    }
}
