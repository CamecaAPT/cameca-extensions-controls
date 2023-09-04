using System.Collections;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Cameca.Extensions.Controls;

public class Chart3D : Control
{
	public static readonly IEnumerable DataSourceDefault = Enumerable.Empty<object>();

	public static readonly DependencyProperty DataSourceProperty = DependencyProperty.Register(
		nameof(DataSource), typeof(IEnumerable), typeof(Chart3D), new FrameworkPropertyMetadata(DataSourceDefault));

	public IEnumerable DataSource
	{
		get => (IEnumerable)GetValue(DataSourceProperty);
		set => SetValue(DataSourceProperty, value);
	}
}
