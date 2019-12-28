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

        private int mOuterMarginSize = 10;

        private int mWindowRadius = 10;
        #endregion

        #region Public Properties
        public int ResizeBorder { get; set; } = 1;

        public Thickness ResizeBorderThickness { get { return new Thickness (ResizeBorder + OuterMarginSize); } }

        public int OuterMarginSize
        {
            get
            {
                return mWindow.WindowState == WindowState.Maximized ? 0 : mOuterMarginSize;
            }
            set
            {
                mOuterMarginSize = value;
            }
        }

        public Thickness OuterMarginSizeThickness { get { return new Thickness(OuterMarginSize); } }

        public int WindowRadius
        {
            get
            {
                return mWindow.WindowState == WindowState.Maximized ? 0 : mWindowRadius;
            }
            set
            {
                mWindowRadius = value;
            }
        }
        #endregion

        public CornerRadius WindowCornerRadius { get { return new CornerRadius(WindowRadius); } }

        public int TitleHeight { get; set; } = 42;

        #region Constructor
        public WindowViewModel(Window window)
        {
            mWindow = window;

            mWindow.StateChanged += (sender, e) =>
            {
                OnPropertyChanged(nameof(ResizeBorderThickness));
                OnPropertyChanged(nameof(OuterMarginSize));
                OnPropertyChanged(nameof(OuterMarginSizeThickness));
                OnPropertyChanged(nameof(WindowRadius));
                OnPropertyChanged(nameof(WindowCornerRadius));
            };
        }

        #endregion
    }
}
