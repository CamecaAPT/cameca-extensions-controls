using System.Collections;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Cameca.Extensions.Controls;

public class Chart2D : Control
{
	private static readonly IEnumerable DataSourceDefault = Enumerable.Empty<object>();

	public static readonly DependencyProperty DataSourceProperty = DependencyProperty.Register(
		nameof(DataSource), typeof(IEnumerable), typeof(Chart2D), new PropertyMetadata(DataSourceDefault));

	public IEnumerable DataSource
	{
		get => (IEnumerable)GetValue(DataSourceProperty);
		set => SetValue(DataSourceProperty, value);
	}

	public static readonly DependencyProperty AxisXLabelProperty = DependencyProperty.Register(
		nameof(AxisXLabel), typeof(string), typeof(Chart2D), new PropertyMetadata("X"));

	public string AxisXLabel
	{
		get => (string)GetValue(AxisXLabelProperty);
		set => SetValue(AxisXLabelProperty, value);
	}

	public static readonly DependencyProperty AxisYLabelProperty = DependencyProperty.Register(
		nameof(AxisYLabel), typeof(string), typeof(Chart2D), new PropertyMetadata("Y"));

	public string AxisYLabel
	{
		get => (string)GetValue(AxisYLabelProperty);
		set => SetValue(AxisYLabelProperty, value);
	}

	public static readonly DependencyProperty ChartPaddingProperty = DependencyProperty.Register(
		nameof(ChartPadding), typeof(Thickness), typeof(Chart2D), new PropertyMetadata(default(Thickness)));

	public Thickness ChartPadding
	{
		get => (Thickness)GetValue(ChartPaddingProperty);
		set => SetValue(ChartPaddingProperty, value);
	}
}
