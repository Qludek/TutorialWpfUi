using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace FasettoWord
{
    public static class StoryboardHelpers
    {
        public static void AddSlideFromRight(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f)
        {
            var animation = new ThicknessAnimation { Duration = new Duration(TimeSpan.FromSeconds(seconds)), From = new Thickness(offset, 0, -offset, 0), To = new Thickness(0), DecelerationRatio = decelerationRatio };

            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            storyboard.Children.Add(animation);
        }
    }
}
