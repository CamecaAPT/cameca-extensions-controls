using System.Collections;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Cameca.Extensions.Controls;

public class Table : Control
{
	private const bool AutoWidthDefault = false;
	private static readonly IEnumerable ItemsSourceDefault = Enumerable.Empty<object>();

	public static readonly DependencyProperty AutoWidthProperty = DependencyProperty.Register(
		nameof(AutoWidth), typeof(bool), typeof(Table), new PropertyMetadata(AutoWidthDefault));

	public static readonly DependencyProperty ItemsSourceProperty = DependencyProperty.Register(
		nameof(ItemsSource), typeof(IEnumerable), typeof(Table), new PropertyMetadata(ItemsSourceDefault));

	public bool AutoWidth
	{
		get => (bool)GetValue(AutoWidthProperty);
		set => SetValue(AutoWidthProperty, value);
	}

	public IEnumerable ItemsSource
	{
		get => (IEnumerable)GetValue(ItemsSourceProperty);
		set => SetValue(ItemsSourceProperty, value);
	}
}
