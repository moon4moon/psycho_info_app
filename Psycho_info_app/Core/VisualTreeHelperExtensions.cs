using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;

public static class VisualTreeHelperExtensions
{
    public static IEnumerable<DependencyObject> GetAllChildren(DependencyObject parent)
    {
        if (parent == null) yield break;

        for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
        {
            var child = VisualTreeHelper.GetChild(parent, i);
            yield return child;

            foreach (var subChild in GetAllChildren(child))
            {
                yield return subChild;
            }
        }
    }
}
