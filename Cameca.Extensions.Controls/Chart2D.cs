using System.Collections;
using System.Linq;
using System.Numerics;
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

	public static readonly DependencyProperty ViewportLowerProperty = DependencyProperty.Register(
		nameof(ViewportLower), typeof(Vector2), typeof(Chart2D), new FrameworkPropertyMetadata());

	public Vector2 ViewportLower
	{
		get => (Vector2)GetValue(ViewportLowerProperty);
		set => SetValue(ViewportLowerProperty, value);
	}

	public static readonly DependencyProperty ViewportUpperProperty = DependencyProperty.Register(
		nameof(ViewportUpper), typeof(Vector2), typeof(Chart2D), new FrameworkPropertyMetadata());

	public Vector2 ViewportUpper
	{
		get => (Vector2)GetValue(ViewportLowerProperty);
		set => SetValue(ViewportUpperProperty, value);
	}

	public static readonly DependencyProperty MouseDataCoordinateProperty = DependencyProperty.Register(
		nameof(MouseDataCoordinate), typeof(Vector3), typeof(Chart2D), new FrameworkPropertyMetadata());

	public Vector3 MouseDataCoordinate
	{
		get => (Vector3)GetValue(ViewportLowerProperty);
		set => SetValue(MouseDataCoordinateProperty, value);
	}

	public static readonly DependencyProperty ProjectionProperty = DependencyProperty.Register(
		nameof(Projection), typeof(Projection2D), typeof(Chart2D), new PropertyMetadata(ProjectionDefault));

	public Projection2D Projection
	{
		get => (Projection2D)GetValue(ProjectionProperty);
		set => SetValue(ProjectionProperty, value);
	}
}
