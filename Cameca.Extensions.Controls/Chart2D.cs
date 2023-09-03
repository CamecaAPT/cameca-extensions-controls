using System.Collections;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Cameca.Extensions.Controls;

public class Chart2D : Control
{
	private static readonly IEnumerable DataSourceDefault = Enumerable.Empty<object>();
	private const bool IsLogScaleYDefault = false;
	private const bool IsLegendVisibleDefault = false;
	private const Projection2D ProjectionDefault = Projection2D.XZ;

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

	public static readonly DependencyProperty IsLogScaleYProperty = DependencyProperty.Register(
		nameof(IsLogScaleY), typeof(bool), typeof(Chart2D), new PropertyMetadata(IsLogScaleYDefault));

	public bool IsLogScaleY
	{
		get => (bool)GetValue(IsLogScaleYProperty);
		set => SetValue(IsLogScaleYProperty, value);
	}

	public static readonly DependencyProperty ChartPaddingProperty = DependencyProperty.Register(
		nameof(ChartPadding), typeof(Thickness), typeof(Chart2D), new PropertyMetadata(default(Thickness)));

	public Thickness ChartPadding
	{
		get => (Thickness)GetValue(ChartPaddingProperty);
		set => SetValue(ChartPaddingProperty, value);
	}

	public static readonly DependencyProperty IsLegendVisibleProperty = DependencyProperty.Register(
		nameof(IsLegendVisible), typeof(bool), typeof(Chart2D), new PropertyMetadata(IsLegendVisibleDefault));

	public bool IsLegendVisible
	{
		get => (bool)GetValue(IsLegendVisibleProperty);
		set => SetValue(IsLegendVisibleProperty, value);
	}

	public static readonly DependencyProperty ProjectionProperty = DependencyProperty.Register(
		nameof(Projection), typeof(Projection2D), typeof(Chart2D), new PropertyMetadata(ProjectionDefault));

	public Projection2D Projection
	{
		get => (Projection2D)GetValue(ProjectionProperty);
		set => SetValue(ProjectionProperty, value);
	}
}
